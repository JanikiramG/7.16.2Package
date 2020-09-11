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

	#region Class: SysAdminUnitColumnPermissionsGridPageSchema

	/// <exclude/>
	public class SysAdminUnitColumnPermissionsGridPageSchema : Terrasoft.WebApp.BaseVirtualGridPageSchema
	{

		#region Constructors: Public

		public SysAdminUnitColumnPermissionsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysAdminUnitColumnPermissionsGridPageSchema(SysAdminUnitColumnPermissionsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("4ca863ea-29a7-438e-b331-b3519f312f94");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("4ca863ea-29a7-438e-b331-b3519f312f94");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("4ca863ea-29a7-438e-b331-b3519f312f94");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("4ca863ea-29a7-438e-b331-b3519f312f94");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {};
			PrintButton.ModifiedInSchemaUId = new Guid("4ca863ea-29a7-438e-b331-b3519f312f94");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("4ca863ea-29a7-438e-b331-b3519f312f94");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.Hidden = true;
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("4ca863ea-29a7-438e-b331-b3519f312f94");
		}

		private void UpdateTreeGrid() {
			TreeGrid.FooterVisible = false;
			TreeGrid.ModifiedInSchemaUId = new Guid("4ca863ea-29a7-438e-b331-b3519f312f94");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4ca863ea-29a7-438e-b331-b3519f312f94");
			RealUId = new Guid("4ca863ea-29a7-438e-b331-b3519f312f94");
			Name = "SysAdminUnitColumnPermissionsGridPage";
			ParentSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysAdminUnitColumnPermissionsGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
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

		protected virtual EmbeddedProcessSchema CreateSysAdminUnitColumnPermissionsGridPageEventsProcessSchema() {
			var schema = new SysAdminUnitColumnPermissionsGridPageEventsProcessSchema(ProcessSchemaManager, this);
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
			return new SysAdminUnitColumnPermissionsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysAdminUnitColumnPermissionsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4ca863ea-29a7-438e-b331-b3519f312f94"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysAdminUnitColumnPermissionsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitColumnPermissionsGridPageEventsProcess

	/// <exclude/>
	public class SysAdminUnitColumnPermissionsGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseVirtualGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysAdminUnitColumnPermissionsGridPageSchemaUserControl
	{

		public SysAdminUnitColumnPermissionsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysAdminUnitColumnPermissionsGridPageEventsProcess";
			SchemaUId = new Guid("4ca863ea-29a7-438e-b331-b3519f312f94");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4ca863ea-29a7-438e-b331-b3519f312f94");
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

		private LocalizableString _objectColumnCaption;
		public LocalizableString ObjectColumnCaption {
			get {
				return _objectColumnCaption ?? (_objectColumnCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ObjectColumnCaption.Value"));
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

		public override DataSourceRowConfig TreeGridConfigHandler(Entity row) {
			string primaryColumnName = row.Schema.PrimaryColumn.Name;
			string primaryColumnValue = row.GetColumnValue(primaryColumnName).ToString();
			var config = new DataSourceRowConfig(primaryColumnValue);
			if (row.GetColumnValue("Type").ToString() == "EntitySchemaColumn") {
				config.AddConfig(new DataSourceRowIsExpandableConfigValue(false));
				var icons = new Dictionary<string, ImageConfigValue>();		
				string imageName = string.Empty;
				if (row.GetTypedColumnValue<Guid>("RightLevel")  == new Guid("007F04EE-1FE1-DF11-971B-001D60E938C6")){
					imageName = "AllowAndGrant.png";
				}
				if (row.GetTypedColumnValue<Guid>("RightLevel")  == new Guid("C6EAA3F4-1FE1-DF11-971B-001D60E938C6")){
					imageName = "Allow.png";		
				}
				if (row.GetTypedColumnValue<Guid>("RightLevel")  == new Guid("C7EAA3F4-1FE1-DF11-971B-001D60E938C6")){
					imageName = "Deny.png";		
				}
				icons.Add("Name", new ImageConfigValue(imageName));
				var iconConfig = new DataSourceRowColumnIconsConfigValue(icons);		
				config.AddConfig(iconConfig);
			}
			return config;
		}

		public override List<Dictionary<string, object>> GetStructureDefinition() {
			List<Dictionary<string, object>> structure = new List<Dictionary<string, object>>();
			var entitySchemaManager = Page.UserConnection.EntitySchemaManager;
			var column = new Dictionary<string, object>() {
				{"Name", "Id"},
				{"ValueColumnName", "Id"},
				{"DisplayColumnName", "Id"},
				{"DataValueType", "Guid"},
				{"Caption", "Id"},
				{"IsVisible", false},
				{"IsSortable", false},
				{"IsPrimaryColumn", true}
			};
			structure.Add(column);
			column = new Dictionary<string, object>() {
				{"Name", "Name"},
				{"ValueColumnName", "Name"},
				{"DisplayColumnName", "Name"},
				{"DataValueType", "Text"},
				{"Caption", ObjectColumnCaption},
				{"IsVisible", true},
				{"IsSortable", false}
			};
			structure.Add(column);
			column = new Dictionary<string, object>() {
				{"Name", "ParentId"},
				{"ValueColumnName", "ParentId"},
				{"DisplayColumnName", "ParentId"},
				{"DataValueType", "Guid"},
				{"Caption", "ParentId"},
				{"IsVisible", false},
				{"IsSortable", false},
				{"IsHierarchicalColumn", true}
			};
			structure.Add(column);
			column = new Dictionary<string, object>() {
				{"Name", "Type"},
				{"ValueColumnName", "Type"},
				{"DisplayColumnName", "Type"},
				{"DataValueType", "Text"},
				{"Caption", "Type"},
				{"IsVisible", false},
				{"IsSortable", false}
			};
			structure.Add(column);
			column = new Dictionary<string, object>() {
				{"Name", "RightLevel"},
				{"ValueColumnName", "RightLevel"},
				{"DisplayColumnName", "RightLevel"},
				{"DataValueType", "Guid"},
				{"Caption", "RightLevel"},
				{"IsVisible", false},
				{"IsSortable", false}
			};
			structure.Add(column);
			return structure;
		}

		public override void FillData(DataSourceRequest dataSourceRequest) {
			Page.TreeGrid.Clear();
			var dataSource = GetDataSource();
			dataSource.Clear();
			var entitySchemaManager = Page.UserConnection.EntitySchemaManager;
			var rightsSchema = entitySchemaManager.GetInstanceByName("VwSysEntitySchemaColumnRight");
			Terrasoft.Core.DB.Select select = new Terrasoft.Core.DB.Select(Page.UserConnection)
			.Column(rightsSchema.Name, "Id")
			.Column(rightsSchema.Name, "SubjectSchemaUId")
			.Column(rightsSchema.Name, "SubjectColumnUId")
			.Column("RightLevel","Name").As("RightLevelName")
			.Column("RightLevel","Id").As("RightLevelId")
			.From(rightsSchema.Name)
			.InnerJoin("SysEntitySchemaColRightLevel").As("RightLevel")
			.On("RightLevel", "Id").IsEqual(rightsSchema.Name, "RightLevelId") as Select;
			string code = GetViewCode();
			if (code == "All" && SelectedNodePrimaryColumnValue != Guid.Empty) {
				var filterValuesObj = Page.UserConnection.DBSecurityEngine.GetUserAdminUnitCollection(SelectedNodePrimaryColumnValue);
				select.And("SysAdminUnitId")
				.In(Terrasoft.Core.DB.Column.Parameters(filterValuesObj));
			} else {
				select.And("SysAdminUnitId").IsEqual(Column.Parameter(SelectedNodePrimaryColumnValue));
			}
			select.OrderByAsc(rightsSchema.Name, "SubjectSchemaUId");
			select.OrderByAsc(rightsSchema.Name, "SubjectColumnUId");
			select.OrderByAsc(rightsSchema.Name, "Position");
			string schemaName = String.Empty;
			string columnName = String.Empty;
			Guid schemaId = Guid.Empty;
			Guid columnId = Guid.Empty;
			Guid curSchemaId = Guid.Empty;
			Guid curColumnId = Guid.Empty;
			Guid sParentId = Guid.Empty;
			Guid cParentId = Guid.Empty;
			Entity row;
			int ordinal;
			string rightLevelName = String.Empty;
			EntitySchema entitySchema = null;
			EntitySchemaColumn entityColumn;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var reader = select.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						ordinal = reader.GetOrdinal("SubjectSchemaUId");
						if (!reader.IsDBNull(ordinal)) {
							schemaId = UserConnection.DBTypeConverter.DBValueToGuid(reader[ordinal]);
							entitySchema = entitySchemaManager.FindInstanceByUId(schemaId);
							if (entitySchema == null) {
								continue;
							}
							schemaName = entitySchema.Caption.Value;
						}
						ordinal = reader.GetOrdinal("SubjectColumnUId");
						if (!reader.IsDBNull(ordinal)) {
							columnId = UserConnection.DBTypeConverter.DBValueToGuid(reader[ordinal]);
							entityColumn = entitySchema.Columns.FindByUId(columnId);
							if (entityColumn == null) {
								continue;
							}
							columnName = entityColumn.Caption.Value;
							entityColumn = null;
						}
						if (!schemaId.Equals(curSchemaId)) {
							row = dataSource.CreateRow();
							sParentId = Guid.NewGuid();
							row.SetColumnValue("Id", sParentId);
							row.SetColumnValue("Name", schemaName);
							row.SetColumnValue("ParentId", null);
							row.SetColumnValue("Type", "EntitySchema");
							dataSource.Add(row);
							curSchemaId = schemaId;
						}
						if (!columnId.Equals(curColumnId)) {
							row = dataSource.CreateRow();
							cParentId = Guid.NewGuid();
							row.SetColumnValue("Id", cParentId);
							row.SetColumnValue("Name", columnName);
							row.SetColumnValue("ParentId", sParentId);
							row.SetColumnValue("Type", "EntitySchemaColumn");
							var rightLevelId = reader["RightLevelId"];
							if (rightLevelId != null && new Guid(rightLevelId.ToString()) != Guid.Empty) {
								row.SetColumnValue("RightLevel", new Guid(rightLevelId.ToString()));
							}
							dataSource.Add(row);
							curColumnId = columnId;
						}
					}
				}
			}
			dataSource.LoadRows(dataSourceRequest);
		}

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

	#region Class: SysAdminUnitColumnPermissionsGridPageEventsProcess

	/// <exclude/>
	public class SysAdminUnitColumnPermissionsGridPageEventsProcess : SysAdminUnitColumnPermissionsGridPageEventsProcess<Terrasoft.WebApp.SysAdminUnitColumnPermissionsGridPageSchemaUserControl>
	{

		public SysAdminUnitColumnPermissionsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysAdminUnitColumnPermissionsGridPageSchemaUserControl

	/// <exclude/>
	public partial class SysAdminUnitColumnPermissionsGridPageSchemaUserControl : Terrasoft.WebApp.BaseVirtualGridPageSchemaUserControl
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
			var process = (SysAdminUnitColumnPermissionsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysAdminUnitColumnPermissionsGridPageEventsProcess(UserConnection);
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
			SchemaName = "SysAdminUnitColumnPermissionsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitColumnPermissionsGridPageEventsProcessSchema

	/// <exclude/>
	public class SysAdminUnitColumnPermissionsGridPageEventsProcessSchema : Terrasoft.WebApp.BaseVirtualGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysAdminUnitColumnPermissionsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysAdminUnitColumnPermissionsGridPageEventsProcessSchema(SysAdminUnitColumnPermissionsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysAdminUnitColumnPermissionsGridPageEventsProcess";
			UId = new Guid("85cc5144-2d77-46e3-988f-e0fdceb82b71");
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

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateObjectColumnCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateObjectColumnCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("364ec269-3b7e-4956-b347-3cfdc713aed0"),
				Name = "ObjectColumnCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("85cc5144-2d77-46e3-988f-e0fdceb82b71"),
				ModifiedInSchemaUId = new Guid("85cc5144-2d77-46e3-988f-e0fdceb82b71")
			};
			return localizableString;
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

		protected override SchemaMethod CreateTreeGridConfigHandlerMethod() {
			SchemaMethod method = base.CreateTreeGridConfigHandlerMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,147,95,107,194,48,20,197,159,219,79,17,242,212,130,150,22,69,39,254,129,174,86,17,198,24,42,123,207,218,88,3,109,82,210,84,87,134,223,125,137,169,91,93,101,15,250,154,155,123,206,239,220,220,20,130,19,154,128,156,147,12,241,42,96,105,153,209,87,148,97,48,5,156,29,157,77,180,199,25,114,222,154,101,71,213,199,102,113,163,243,29,165,229,165,117,137,69,227,208,106,57,216,206,150,109,206,26,150,61,54,15,136,131,136,209,29,73,100,59,197,71,48,71,2,109,88,201,35,188,102,199,224,92,177,218,94,178,147,236,128,117,195,15,110,171,28,195,166,9,152,78,1,12,169,32,162,210,177,244,117,104,131,47,211,208,222,142,31,199,181,87,139,97,85,132,159,57,162,49,250,72,177,190,163,141,118,40,45,176,45,65,12,149,129,72,161,226,18,129,68,130,48,42,137,39,122,88,29,176,202,80,210,236,158,201,236,134,97,26,245,48,137,42,215,227,215,71,78,152,229,162,146,226,141,152,42,89,220,200,58,89,150,36,158,89,112,77,146,189,120,193,7,156,202,76,42,173,130,80,53,11,186,238,112,225,246,195,176,235,45,66,175,59,95,120,94,119,52,244,158,187,174,235,205,7,110,56,234,61,5,3,104,219,114,16,70,147,1,250,105,202,142,62,141,151,28,81,225,228,52,129,18,229,244,40,77,48,8,125,191,183,232,223,69,163,41,212,208,30,231,24,222,199,49,199,180,186,198,80,175,174,150,199,130,234,14,236,156,77,254,62,182,245,35,114,181,46,193,63,107,175,210,172,148,248,149,140,58,208,123,211,90,219,95,65,105,113,50,57,22,37,167,245,207,26,127,3,189,220,35,94,237,3,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetStructureDefinitionMethod() {
			SchemaMethod method = base.CreateGetStructureDefinitionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,148,209,78,194,48,20,134,175,221,83,52,187,130,132,240,2,32,137,1,163,36,168,68,144,251,67,119,132,99,186,142,180,29,186,16,222,221,210,129,206,117,211,105,240,170,201,249,255,115,218,243,229,79,39,164,77,127,68,220,80,34,65,101,125,109,20,201,85,135,37,203,23,228,102,48,96,182,144,114,147,42,100,151,76,226,43,155,252,208,208,106,247,130,45,40,134,210,144,201,102,124,141,49,220,129,132,21,42,59,97,106,207,238,147,70,53,76,164,68,55,164,123,237,59,243,17,60,17,105,44,143,247,214,95,217,106,179,93,112,177,11,239,33,198,176,195,194,113,20,238,59,135,194,2,68,138,67,55,196,211,70,164,55,2,178,58,21,12,184,238,121,182,113,202,77,74,39,109,8,155,195,67,190,248,199,122,65,154,150,226,224,125,6,161,241,84,158,37,202,64,69,125,170,40,182,171,228,215,91,209,66,198,125,176,239,5,31,184,187,87,81,212,202,9,88,162,127,68,225,206,90,24,5,181,18,71,81,47,3,153,227,155,241,128,60,184,87,228,67,142,85,159,143,91,181,14,207,249,17,76,65,217,40,126,151,137,146,163,18,69,217,211,44,31,165,174,95,167,228,150,80,129,226,107,226,32,254,59,42,110,147,90,70,5,181,146,79,81,111,20,149,98,71,115,46,231,95,251,145,86,107,51,193,45,138,250,229,61,79,37,2,223,213,44,36,94,223,89,112,40,180,53,249,249,123,247,222,1,160,22,88,146,233,5,0,0 };
			return method;
		}

		protected override SchemaMethod CreateFillDataMethod() {
			SchemaMethod method = base.CreateFillDataMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,203,110,219,58,16,93,43,64,254,129,209,162,160,129,128,63,16,100,225,87,11,95,180,137,17,59,217,20,93,48,210,36,81,33,147,41,41,197,53,46,242,239,119,248,144,68,61,236,40,192,221,216,16,57,115,56,60,115,102,56,107,254,12,108,171,0,190,169,44,101,243,28,184,162,147,171,243,179,55,174,72,202,11,190,145,165,74,128,92,147,111,80,44,234,111,107,210,108,119,252,64,20,89,113,216,36,47,176,227,63,184,192,19,20,2,172,205,73,247,26,212,92,10,1,73,145,73,193,150,125,75,143,161,178,231,151,66,187,29,116,30,128,100,24,209,74,232,130,139,4,102,135,27,190,3,26,63,236,55,7,29,130,206,101,94,238,196,157,1,139,77,120,91,80,138,107,249,84,176,185,84,192,22,51,182,129,28,131,33,218,253,93,19,1,123,114,204,138,14,220,97,114,126,198,220,41,52,140,153,153,128,46,73,188,74,227,15,44,54,229,227,111,132,114,139,247,163,237,157,69,199,62,182,55,253,14,111,144,199,151,177,113,136,39,108,170,195,117,183,120,204,197,192,117,28,252,9,95,149,220,245,227,49,59,43,164,66,253,35,51,196,234,179,31,160,119,129,45,236,109,39,2,199,24,91,233,229,159,146,231,131,4,180,67,35,92,19,151,29,76,175,46,84,38,158,73,34,83,47,217,135,12,246,115,252,178,218,204,158,8,117,91,215,36,158,230,121,76,190,124,241,190,144,222,224,198,90,101,59,174,14,142,153,7,158,151,64,46,16,166,196,202,88,238,94,139,195,132,252,123,126,22,25,121,62,101,121,1,202,154,232,219,199,223,71,228,189,152,109,32,41,21,242,177,20,207,153,0,35,89,99,50,77,119,153,184,23,153,73,98,238,108,233,233,56,76,248,145,211,40,155,138,212,50,93,163,184,12,69,152,8,218,87,174,3,97,107,174,144,61,140,89,211,78,236,19,131,253,78,32,215,96,175,119,234,148,58,47,93,212,143,194,183,103,96,126,28,246,173,74,65,205,14,83,157,140,172,136,171,79,186,6,197,49,218,117,45,117,102,50,225,92,156,144,180,181,48,6,152,225,141,93,115,74,8,181,102,142,26,54,49,202,241,24,171,148,132,74,170,54,157,247,177,205,82,109,78,58,151,106,126,202,95,99,122,176,113,30,243,62,182,235,42,152,40,185,55,53,35,10,34,85,154,9,158,55,119,86,173,110,210,191,119,216,3,90,173,219,244,215,50,207,59,38,238,18,222,208,125,160,69,169,205,81,212,62,68,143,203,191,88,72,133,52,239,72,239,9,209,165,130,197,172,89,162,19,87,167,1,128,2,158,218,71,200,75,193,193,193,157,93,166,13,188,247,140,246,47,89,14,132,58,55,102,204,42,208,40,242,108,32,152,223,198,162,190,117,107,116,88,186,232,100,90,207,133,183,95,233,197,236,6,89,160,30,169,70,142,2,169,244,58,201,246,240,10,184,240,6,10,203,13,191,109,93,109,165,201,156,143,243,167,199,251,229,207,140,58,204,15,189,161,95,51,145,54,143,40,6,76,171,24,42,16,19,121,27,200,229,176,14,58,74,36,110,139,18,188,195,123,120,23,175,143,16,128,205,249,171,189,147,189,129,115,122,31,205,108,187,178,71,51,27,212,217,255,199,172,215,109,247,122,118,85,91,106,29,165,213,225,125,74,43,132,113,148,182,90,77,8,48,68,105,55,70,95,119,53,154,229,173,74,54,179,93,93,211,160,227,52,220,97,35,64,255,112,218,67,86,176,120,228,158,86,55,234,117,154,27,216,91,254,42,3,196,192,25,170,8,158,4,106,30,250,203,166,71,157,178,180,51,203,101,208,141,79,25,87,128,232,96,73,61,97,106,50,111,70,142,176,25,85,186,138,130,11,79,83,84,130,220,87,59,237,190,92,113,216,35,183,74,123,64,110,213,174,63,69,110,175,81,143,38,55,249,4,185,141,184,70,146,59,42,115,67,12,59,131,154,231,122,218,247,35,93,93,254,63,219,147,222,175,160,122,90,246,23,78,220,102,152,51,195,187,171,219,192,128,109,165,123,159,76,15,31,152,231,142,197,222,26,75,63,68,158,180,107,245,164,122,130,87,187,18,73,160,30,243,243,110,199,165,0,228,187,228,41,138,66,211,102,237,14,254,224,4,87,76,174,254,3,132,44,49,249,196,13,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysAdminUnitColumnPermissionsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("85cc5144-2d77-46e3-988f-e0fdceb82b71"));
		}

		#endregion

	}

	#endregion

}

