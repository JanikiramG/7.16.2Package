namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: SysAdminUnitGranteeObjectsByDefaultGridPageSchema

	/// <exclude/>
	public class SysAdminUnitGranteeObjectsByDefaultGridPageSchema : Terrasoft.WebApp.BaseVirtualGridPageSchema
	{

		#region Constructors: Public

		public SysAdminUnitGranteeObjectsByDefaultGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysAdminUnitGranteeObjectsByDefaultGridPageSchema(SysAdminUnitGranteeObjectsByDefaultGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("15e00d01-82aa-4a34-a6a5-fd0472c50fb1");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("15e00d01-82aa-4a34-a6a5-fd0472c50fb1");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("15e00d01-82aa-4a34-a6a5-fd0472c50fb1");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("15e00d01-82aa-4a34-a6a5-fd0472c50fb1");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {};
			PrintButton.ModifiedInSchemaUId = new Guid("15e00d01-82aa-4a34-a6a5-fd0472c50fb1");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("15e00d01-82aa-4a34-a6a5-fd0472c50fb1");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.Hidden = true;
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("15e00d01-82aa-4a34-a6a5-fd0472c50fb1");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("15e00d01-82aa-4a34-a6a5-fd0472c50fb1");
			RealUId = new Guid("15e00d01-82aa-4a34-a6a5-fd0472c50fb1");
			Name = "SysAdminUnitGranteeObjectsByDefaultGridPage";
			ParentSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysAdminUnitGranteeObjectsByDefaultGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateButtonsControlLayout();
			UpdateContextHelpButton();
			UpdatePrintButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			TopLevelControl.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.MoveItem(4, Spacer);
			ButtonsControlLayout.MoveItem(5, PrintButton);
			ButtonsControlLayout.MoveItem(6, ContextHelpButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysAdminUnitGranteeObjectsByDefaultGridPageEventsProcessSchema() {
			var schema = new SysAdminUnitGranteeObjectsByDefaultGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SysAdminUnitGranteeObjectsByDefaultGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysAdminUnitGranteeObjectsByDefaultGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("15e00d01-82aa-4a34-a6a5-fd0472c50fb1"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysAdminUnitGranteeObjectsByDefaultGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitGranteeObjectsByDefaultGridPageEventsProcess

	/// <exclude/>
	public class SysAdminUnitGranteeObjectsByDefaultGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseVirtualGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysAdminUnitGranteeObjectsByDefaultGridPageSchemaUserControl
	{

		public SysAdminUnitGranteeObjectsByDefaultGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysAdminUnitGranteeObjectsByDefaultGridPageEventsProcess";
			SchemaUId = new Guid("15e00d01-82aa-4a34-a6a5-fd0472c50fb1");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("15e00d01-82aa-4a34-a6a5-fd0472c50fb1");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString() + 
				Page.PageContainer.UniqueID;
			}
		}

		public virtual Object Code {
			get;
			set;
		}

		private LocalizableString _objectCaption;
		public LocalizableString ObjectCaption {
			get {
				return _objectCaption ?? (_objectCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ObjectCaption.Value"));
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

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "Code":
					Code = reader.GetSerializableObjectValue();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public override Select CreateSelect() {
			var entitySchemaManager = Page.UserConnection.EntitySchemaManager;
			
			//Код, который компилируется только в Workspace CR173384
			var select = new Terrasoft.Core.DB.Select(Page.UserConnection)
				.Column("SysEntitySchemaRecordDefRight", "Id")
				.Column("SysEntitySchemaRecordDefRight", "SubjectSchemaUId").As("SubjectSchemaId")
				.Column("VwSysSchemaInfo", "Caption").As("SubjectSchemaCaption") 
				.Column("SysEntitySchemaRecordDefRight", "AuthorSysAdminUnitId").As("AuthorId")
				.Column("Author", "Name").As("AuthorName")
				.Column("SysEntitySchemaRecordDefRight", "GranteeSysAdminUnitId").As("GranteeId")
				.Column("Grantee", "Name").As("GranteeName")
				.Column("SysEntitySchemaRecordDefRight", "Position")
				.Column("EntitySchemaRecRightOperation", "Id").As("OperationId")
				.Column("EntitySchemaRecRightOperation", "Name").As("OperationName")
				.Column("RightLevel", "Id").As("RightLevelId")
				.Column("RightLevel", "Name").As("RightLevelName")
				.From("SysEntitySchemaRecordDefRight")
				.InnerJoin("SysAdminUnit").As("Author").On("Author", "Id").IsEqual("SysEntitySchemaRecordDefRight", "AuthorSysAdminUnitId")
				.InnerJoin("SysAdminUnit").As("Grantee").On("Grantee", "Id").IsEqual("SysEntitySchemaRecordDefRight", "GranteeSysAdminUnitId")
				.InnerJoin("VwSysSchemaInfo").On("VwSysSchemaInfo", "UId").IsEqual("SysEntitySchemaRecordDefRight", "SubjectSchemaUId")
				.InnerJoin("SysEntitySchemaRecOprRightLvl").As("RightLevel").On("RightLevel", "Value").IsEqual("SysEntitySchemaRecordDefRight", "RightLevel")
				.InnerJoin("EntitySchemaRecRightOperation").On("EntitySchemaRecRightOperation", "Value").IsEqual("SysEntitySchemaRecordDefRight", "Operation")
				.OrderByAsc("SysEntitySchemaRecordDefRight", "SubjectSchemaUId")
				.OrderByAsc("SysEntitySchemaRecordDefRight", "Position")
				as Terrasoft.Core.DB.Select;
			string viewCode = GetViewCode();
			select.Where("VwSysSchemaInfo", "SysWorkspaceId").IsEqual(Column.Parameter(UserConnection.Workspace.Id))
				.And("SysEntitySchemaRecordDefRight", "Operation").IsEqual(new QueryParameter(viewCode));
			if (Code.ToString() == "All") {
				var filterValuesObj = Page.UserConnection.DBSecurityEngine.GetUserAdminUnitCollection(SelectedNodePrimaryColumnValue);
				select.And("SysEntitySchemaRecordDefRight", "AuthorSysAdminUnitId")
				.In(Terrasoft.Core.DB.Column.Parameters(filterValuesObj));
			} else {
				select.And("SysEntitySchemaRecordDefRight", "AuthorSysAdminUnitId").IsEqual(Column.Parameter(SelectedNodePrimaryColumnValue));
			}
			return select;
		}

		public override List<Dictionary<string, object>> GetStructureDefinition() {
			List<Dictionary<string, object>> structure = new List<Dictionary<string, object>>();
			var entitySchemaManager = Page.UserConnection.EntitySchemaManager;
			var schema = entitySchemaManager.GetInstanceByName("SysEntitySchemaRecordDefRight");
			var column = new Dictionary<string, object>() {
				{"Name", "Id"},
				{"DisplayColumnName", "Id"},
				{"ValueColumnName", "Id"},
				{"DataValueType", "Guid"},
				{"Caption", "Id"},
				{"IsVisible", false},
				{"IsSortable", false},
				{"IsPrimaryColumn", true}
			};
			structure.Add(column);
			
			//Код, который компилируется только в Workspace CR173384
			column = new Dictionary<string, object>() {
				{"Name", "SubjectSchema"},
				{"ValueColumnName", "SubjectSchemaId"},
				{"DisplayColumnName", "SubjectSchemaCaption"},
				{"DataValueType", "Lookup"},
				{"ReferenceSchemaUId", entitySchemaManager.GetInstanceByName("VwSysSchemaInfo").UId},
				{"ReferenceSchemaName", "VwSysSchemaInfo"},
				{"ReferenceSchemaPrimaryColumnName", "Id"},
				{"Caption", ObjectCaption.Value},
				{"IsVisible", true},
				{"IsSortable", false}
			};
			
			structure.Add(column);
			column = new Dictionary<string, object>() {
				{"Name", "Author"},
				{"ValueColumnName", "AuthorId"},
				{"DisplayColumnName", "AuthorName"},
				{"DataValueType", "Lookup"},
				{"ReferenceSchemaUId", entitySchemaManager.GetInstanceByName("VwSysAdminUnit").UId},
				{"ReferenceSchemaName", "VwSysAdminUnit"},
				{"ReferenceSchemaPrimaryColumnName", "Id"},
				{"ReferenceSchemaPrimaryDisplayColumnName", "Name"},
				{"Caption", schema.Columns.GetByName("Author").Caption},
				{"IsVisible", true},
				{"IsSortable", false}
			};
			structure.Add(column);
			column = new Dictionary<string, object>() {
				{"Name", "Grantee"},
				{"ValueColumnName", "GranteeId"},
				{"DisplayColumnName", "GranteeName"},
				{"DataValueType", "Lookup"},
				{"ReferenceSchemaUId", entitySchemaManager.GetInstanceByName("VwSysAdminUnit").UId},
				{"ReferenceSchemaName", "VwSysAdminUnit"},
				{"ReferenceSchemaPrimaryColumnName", "Id"},
				{"ReferenceSchemaPrimaryDisplayColumnName", "Name"},
				{"Caption", schema.Columns.GetByName("Grantee").Caption},
				{"IsVisible", true},
				{"IsSortable", false}
			};
			structure.Add(column);
			column = new Dictionary<string, object> {
				{"Name", "Operation"},
				{"ValueColumnName", "OperationId"},
				{"DisplayColumnName", "OperationName"},
				{"DataValueType", "Lookup"},
				{"ReferenceSchemaUId", entitySchemaManager.GetInstanceByName("EntitySchemaRecRightOperation").UId},
				{"ReferenceSchemaName", "EntitySchemaRecRightOperation"},
				{"ReferenceSchemaPrimaryColumnName", "Id"},
				{"ReferenceSchemaPrimaryDisplayColumnName", "Name"},
				{"Caption", schema.Columns.GetByName("Operation").Caption},
				{"IsVisible", false},
				{"IsSortable", false}
			};
			structure.Add(column);
			column = new Dictionary<string, object> {
				{"Name", "RightLevel"},
				{"ValueColumnName", "RightLevelId"},
				{"DisplayColumnName", "RightLevelName"},
				{"DataValueType", "Lookup"},
				{"ReferenceSchemaUId", entitySchemaManager.GetInstanceByName("SysEntitySchemaRecOprRightLvl").UId},
				{"ReferenceSchemaName", "SysEntitySchemaRecOprRightLvl"},
				{"ReferenceSchemaPrimaryColumnName", "Id"},
				{"ReferenceSchemaPrimaryDisplayColumnName", "Name"},
				{"Caption", schema.Columns.GetByName("RightLevel").Caption},
				{"IsVisible", true},
				{"IsSortable", false}
			};
			structure.Add(column);
			return structure;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (Code != null) {
				if (Code.GetType().IsSerializable ||
					Code.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("Code", Code, null);
				}
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitGranteeObjectsByDefaultGridPageEventsProcess

	/// <exclude/>
	public class SysAdminUnitGranteeObjectsByDefaultGridPageEventsProcess : SysAdminUnitGranteeObjectsByDefaultGridPageEventsProcess<Terrasoft.WebApp.SysAdminUnitGranteeObjectsByDefaultGridPageSchemaUserControl>
	{

		public SysAdminUnitGranteeObjectsByDefaultGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysAdminUnitGranteeObjectsByDefaultGridPageSchemaUserControl

	/// <exclude/>
	public partial class SysAdminUnitGranteeObjectsByDefaultGridPageSchemaUserControl : Terrasoft.WebApp.BaseVirtualGridPageSchemaUserControl
	{

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SysAdminUnitGranteeObjectsByDefaultGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysAdminUnitGranteeObjectsByDefaultGridPageEventsProcess(UserConnection);
				process.Page = this;
				Process = process;
				UserConnection.ProcessEngine.SetProcess(process);
				process.Execute(UserConnection);
				UserConnection.ProcessEngine.SetProcessPropertiesData(process);
			} else {
				process.InternalContext = new ProcessExecutingContext(UserConnection) {
					Process = process
				};
				process.Page = this;
				Process = process;
				UserConnection.ProcessEngine.SetProcess(process);
			}
		}

		protected override void InitializePageSchemaControls() {
			base.InitializePageSchemaControls();
			if (!PageContainer.IsDesignMode) {
					InitializeEmbeddedProcess();
				}
		}

		#endregion

		#region Methods: Public

		public override void AddScript(string script) {
			this.ScriptManager.AddScript(script);
		}

		public override void RegisterClientScriptIncludeInternal(string key, string resourceName) {
			this.ScriptManager.RegisterClientScriptIncludeInternal(key, resourceName);
		}

		public override void RegisterClientScriptBlock(string key, string script) {
			this.ScriptManager.RegisterClientScriptBlock(key, script);
		}

		public override void SetSchemaName() {
			SchemaName = "SysAdminUnitGranteeObjectsByDefaultGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitGranteeObjectsByDefaultGridPageEventsProcessSchema

	/// <exclude/>
	public class SysAdminUnitGranteeObjectsByDefaultGridPageEventsProcessSchema : Terrasoft.WebApp.BaseVirtualGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysAdminUnitGranteeObjectsByDefaultGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysAdminUnitGranteeObjectsByDefaultGridPageEventsProcessSchema(SysAdminUnitGranteeObjectsByDefaultGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysAdminUnitGranteeObjectsByDefaultGridPageEventsProcess";
			UId = new Guid("81844e8c-52a5-4e83-b14e-d917abc08bb5");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateCodeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0a0ef45e-043c-48f6-a1c9-713464fe06e0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("81844e8c-52a5-4e83-b14e-d917abc08bb5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("81844e8c-52a5-4e83-b14e-d917abc08bb5"),
				Name = @"Code",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCodeParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1_dd9e9c37957d4fb6baa1b3382a02ba60 = CreateLaneSet1_dd9e9c37957d4fb6baa1b3382a02ba60LaneSet();
			LaneSets.Add(schemaLaneSet1_dd9e9c37957d4fb6baa1b3382a02ba60);
			ProcessSchemaLane schemaLane1_da7b12aef13541f8980134dc888dcc8f = CreateLane1_da7b12aef13541f8980134dc888dcc8fLane();
			schemaLaneSet1_dd9e9c37957d4fb6baa1b3382a02ba60.Lanes.Add(schemaLane1_da7b12aef13541f8980134dc888dcc8f);
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateObjectCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateObjectCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7dfba568-6a1e-44e4-b225-48ff88b65e6f"),
				Name = "ObjectCaption",
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90"),
				CreatedInSchemaUId = new Guid("81844e8c-52a5-4e83-b14e-d917abc08bb5"),
				ModifiedInSchemaUId = new Guid("81844e8c-52a5-4e83-b14e-d917abc08bb5")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1_dd9e9c37957d4fb6baa1b3382a02ba60LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1_dd9e9c37957d4fb6baa1b3382a02ba60 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("dd9e9c37-957d-4fb6-baa1-b3382a02ba60"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("81844e8c-52a5-4e83-b14e-d917abc08bb5"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("81844e8c-52a5-4e83-b14e-d917abc08bb5"),
				Name = @"LaneSet1_dd9e9c37957d4fb6baa1b3382a02ba60",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1_dd9e9c37957d4fb6baa1b3382a02ba60;
		}

		protected virtual ProcessSchemaLane CreateLane1_da7b12aef13541f8980134dc888dcc8fLane() {
			ProcessSchemaLane schemaLane1_da7b12aef13541f8980134dc888dcc8f = new ProcessSchemaLane(this) {
				UId = new Guid("da7b12ae-f135-41f8-9801-34dc888dcc8f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dd9e9c37-957d-4fb6-baa1-b3382a02ba60"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("81844e8c-52a5-4e83-b14e-d917abc08bb5"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("81844e8c-52a5-4e83-b14e-d917abc08bb5"),
				Name = @"Lane1_da7b12aef13541f8980134dc888dcc8f",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1_da7b12aef13541f8980134dc888dcc8f;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e0c6ae3c-b3a0-4e06-b747-2bf038a88cc7"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("917cbfdc-72d8-4e11-9182-d5a8af1cdec3"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9c1bc255-2fee-462f-bbc2-ac404082e1f1"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("71df11d8-5543-4198-929a-6a80e3ed540a"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f")
			});
		}

		protected override SchemaMethod CreateCreateSelectMethod() {
			SchemaMethod method = base.CreateCreateSelectMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,205,110,211,64,16,62,215,79,177,202,201,145,42,87,168,72,32,85,61,228,167,84,65,208,132,164,105,207,219,120,146,108,113,118,195,172,157,42,66,72,80,142,32,113,231,49,16,72,133,162,242,10,155,55,98,215,235,186,182,147,52,184,226,16,37,158,249,102,191,111,254,188,153,81,36,192,67,22,206,123,131,49,76,232,75,202,233,8,144,236,147,142,254,246,250,18,176,33,56,135,65,200,4,247,14,150,145,123,142,179,179,163,190,170,27,245,125,155,168,95,234,102,113,169,63,239,23,159,212,207,248,81,253,86,127,212,149,186,86,87,218,248,81,253,88,92,46,62,44,190,16,131,82,215,139,207,6,66,212,55,114,42,240,181,156,210,1,144,70,247,209,147,221,221,167,143,157,153,150,38,33,208,212,90,13,135,11,114,12,136,84,138,97,232,53,4,130,215,172,123,189,216,237,174,144,90,117,182,52,42,136,38,220,173,244,230,50,43,188,11,3,129,126,19,134,93,54,26,135,149,109,82,105,249,149,82,248,94,116,118,174,105,172,187,111,162,189,154,116,243,230,194,153,39,23,250,212,196,195,135,194,156,210,160,83,163,116,85,112,234,34,101,100,213,162,112,44,80,195,106,254,132,241,62,103,97,42,205,186,10,154,172,209,68,30,209,9,228,144,214,80,134,252,16,41,15,1,86,178,39,190,2,125,98,45,240,39,214,242,2,58,66,50,91,180,76,84,33,36,6,183,167,128,52,70,38,173,143,121,83,107,65,229,198,19,50,218,83,251,146,250,56,236,5,204,32,200,145,222,153,11,172,121,124,134,226,206,145,114,60,67,49,217,84,31,131,107,233,221,192,231,130,217,98,166,93,202,245,93,63,180,115,147,17,75,109,201,131,55,17,13,30,60,130,27,201,111,71,193,178,103,6,163,36,253,154,33,204,243,23,87,209,146,174,88,208,126,73,246,229,215,194,82,226,133,3,218,83,180,13,157,5,75,253,77,116,229,39,225,132,6,17,148,18,149,61,48,47,231,254,201,182,236,27,167,191,188,160,12,133,214,211,70,31,176,62,175,201,193,67,11,92,234,132,236,75,130,202,181,55,202,158,35,67,100,124,68,102,12,46,26,194,7,125,3,29,66,120,146,60,185,85,13,136,129,222,233,24,16,86,78,143,54,164,151,90,110,144,236,142,123,29,138,122,131,67,64,183,112,201,166,81,94,203,175,154,12,107,220,47,87,215,148,202,220,154,175,34,192,249,29,217,109,70,85,157,3,27,18,215,252,246,142,69,47,206,215,173,146,253,125,189,197,129,30,22,242,214,217,50,87,240,144,5,58,46,238,179,108,159,157,175,249,103,208,172,247,96,16,161,214,119,192,71,140,131,167,203,101,32,233,30,234,172,3,139,117,109,141,193,63,210,212,29,100,19,138,115,91,147,152,68,235,218,74,138,251,111,137,223,243,206,113,151,27,92,172,190,116,11,9,154,194,188,35,16,72,48,21,248,15,74,214,55,126,67,33,140,16,7,33,140,144,39,127,132,246,254,2,155,247,251,216,175,9,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetStructureDefinitionMethod() {
			SchemaMethod method = base.CreateGetStructureDefinitionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,151,221,106,26,65,20,199,175,43,248,14,195,94,41,200,134,146,66,11,73,3,86,139,8,182,6,173,246,122,178,30,117,154,117,118,153,157,53,44,65,104,210,203,22,122,223,199,40,45,164,77,73,95,97,246,141,58,59,187,186,126,236,135,72,99,115,209,11,145,153,243,63,199,57,231,255,99,24,91,196,225,199,117,98,112,98,81,204,188,99,135,51,66,71,21,100,157,189,3,131,159,156,32,185,225,26,220,101,128,158,35,10,23,168,149,147,80,42,31,21,11,83,204,16,80,78,184,215,53,198,48,193,175,48,197,35,96,178,196,169,252,214,123,14,176,154,69,41,168,42,250,203,77,101,84,195,81,123,50,45,161,152,222,0,222,164,14,199,212,128,23,222,107,60,129,146,214,245,156,229,98,29,48,44,54,168,195,176,67,70,99,174,205,79,102,88,166,59,161,81,63,233,173,148,202,232,178,88,120,116,169,5,181,181,10,210,154,3,109,86,81,59,117,226,216,38,246,106,170,208,102,184,143,77,23,210,130,117,204,177,18,188,241,108,21,106,184,100,17,172,97,59,56,205,106,70,211,233,19,135,156,153,129,122,136,77,7,22,251,93,139,113,156,20,56,101,100,34,91,10,207,32,163,210,68,152,21,11,51,57,129,133,161,122,117,48,40,133,179,8,38,83,44,28,28,136,47,226,78,124,171,32,241,83,220,249,215,242,243,222,255,40,126,168,165,248,37,126,139,27,113,43,110,228,230,7,241,221,191,246,175,252,207,40,80,137,91,255,83,32,65,226,43,122,107,177,115,199,198,6,160,90,231,241,211,195,195,103,79,138,133,93,231,221,117,85,32,244,50,99,182,43,186,28,147,86,180,243,105,167,57,211,178,172,115,215,158,135,59,48,4,6,146,182,48,185,39,127,169,178,45,152,253,11,137,102,116,64,58,180,180,178,46,211,147,235,206,79,186,158,146,172,94,49,122,19,182,152,167,182,234,59,90,235,170,205,4,188,20,39,169,116,133,0,165,35,180,171,209,85,151,143,45,150,225,112,40,200,177,54,20,169,213,158,12,173,14,38,132,246,40,225,91,251,25,103,236,100,103,178,58,113,26,203,115,136,41,8,47,84,61,148,58,65,99,243,134,34,15,202,122,36,222,17,142,191,141,70,131,97,202,1,50,216,136,20,57,112,68,170,255,116,236,70,199,220,134,127,140,199,26,28,109,27,24,94,190,193,19,240,88,104,114,0,89,232,246,132,200,218,59,69,189,80,226,126,182,32,38,187,192,67,3,104,185,181,116,132,114,94,55,247,193,144,154,91,11,166,96,102,64,20,139,114,40,138,133,123,194,104,243,197,219,182,89,120,138,169,185,13,70,217,5,30,26,70,75,110,221,215,85,196,64,110,210,248,127,207,209,31,183,0,120,21,35,13,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysAdminUnitGranteeObjectsByDefaultGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("81844e8c-52a5-4e83-b14e-d917abc08bb5"));
		}

		#endregion

	}

	#endregion

}

