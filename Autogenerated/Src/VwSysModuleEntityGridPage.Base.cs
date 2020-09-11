namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Text;
	using System.Threading;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.Reports;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using TSConfiguration = Terrasoft.Configuration;
	using web = System.Web;

	#region Class: VwSysModuleEntityGridPageSchema

	/// <exclude/>
	public class VwSysModuleEntityGridPageSchema : Terrasoft.WebApp.BaseLookupGridPageSchema
	{

		#region Constructors: Public

		public VwSysModuleEntityGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public VwSysModuleEntityGridPageSchema(VwSysModuleEntityGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("7ea7bb60-7abb-40b2-af0e-7b4c5354b436");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("7ea7bb60-7abb-40b2-af0e-7b4c5354b436");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("7ea7bb60-7abb-40b2-af0e-7b4c5354b436");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("7ea7bb60-7abb-40b2-af0e-7b4c5354b436");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("7ea7bb60-7abb-40b2-af0e-7b4c5354b436");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("7ea7bb60-7abb-40b2-af0e-7b4c5354b436");
		}

		private void UpdateDownloadTemplateForImportProductsButton() {
			DownloadTemplateForImportProductsButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DownloadTemplateForImportProductsButton.Image = new ControlImage {};
			DownloadTemplateForImportProductsButton.ModifiedInSchemaUId = new Guid("7ea7bb60-7abb-40b2-af0e-7b4c5354b436");
		}

		private void UpdateImportProductsButton() {
			ImportProductsButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ImportProductsButton.Image = new ControlImage {};
			ImportProductsButton.ModifiedInSchemaUId = new Guid("7ea7bb60-7abb-40b2-af0e-7b4c5354b436");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("7ea7bb60-7abb-40b2-af0e-7b4c5354b436");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("7ea7bb60-7abb-40b2-af0e-7b4c5354b436");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("7ea7bb60-7abb-40b2-af0e-7b4c5354b436");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("7ea7bb60-7abb-40b2-af0e-7b4c5354b436");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("7ea7bb60-7abb-40b2-af0e-7b4c5354b436");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("7ea7bb60-7abb-40b2-af0e-7b4c5354b436");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7ea7bb60-7abb-40b2-af0e-7b4c5354b436");
			RealUId = new Guid("7ea7bb60-7abb-40b2-af0e-7b4c5354b436");
			Name = "VwSysModuleEntityGridPage";
			ParentSchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
			CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwSysModuleEntityGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendTemplateEmailMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateActionButton();
			UpdateImportProductsButton();
			UpdateDownloadTemplateForImportProductsButton();
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
			ButtonsControlLayout.MoveItem(4, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(5, PrintButton);
			ButtonsControlLayout.MoveItem(6, ContextHelpButton);
			ButtonsControlLayout.MoveItem(7, DownloadTemplateForImportProductsButton);
			ButtonsControlLayout.MoveItem(8, ImportProductsButton);
			ButtonsControlLayout.MoveItem(9, ActionButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateVwSysModuleEntityGridPageEventsProcessSchema() {
			var schema = new VwSysModuleEntityGridPageEventsProcessSchema(ProcessSchemaManager, this);
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
			return new VwSysModuleEntityGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new VwSysModuleEntityGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7ea7bb60-7abb-40b2-af0e-7b4c5354b436"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new VwSysModuleEntityGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysModuleEntityGridPageEventsProcess

	/// <exclude/>
	public class VwSysModuleEntityGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.VwSysModuleEntityGridPageSchemaUserControl
	{

		public VwSysModuleEntityGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysModuleEntityGridPageEventsProcess";
			SchemaUId = new Guid("7ea7bb60-7abb-40b2-af0e-7b4c5354b436");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7ea7bb60-7abb-40b2-af0e-7b4c5354b436");
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

		private Guid _editPageUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
		public override Guid EditPageUId {
			get {
				return _editPageUId;
			}
			set {
				_editPageUId = value;
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

		public override Guid GetDeafaultLookupEditSchemaId() {
			return new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
		}

		public override void LoadViewFilters(bool enabledFilters) {
			base.LoadViewFilters(enabledFilters);
			var dataSource = Page.DataSource;
			var structure = Page.DataSource.CurrentStructure;
			var filters = dataSource.FindFiltersGroupByName("ViewFilters");
			if (filters != null) {
				structure.Filters.Remove(filters);
			}
			filters = structure.CreateFiltersGroup("ViewFilters", LogicalOperationStrict.And);
			DataSourceFilterExpression leftExpression = structure.CreateDataSourceFilterExpression("SysWorkspace");
			DataSourceFilterExpression rightExpression = structure.CreateDataSourceFilterExpression(
				new object[]{ 
					//new Guid("0C039963-C53D-E111-851E-00155D04C01D")
					
					UserConnection.Workspace.Id 
				});
			var filterItem = new DataSourceFilter(dataSource.Schema, Terrasoft.Core.Entities.FilterComparisonType.Equal,
				leftExpression, rightExpression);
			filterItem.Name = "All";
			filterItem.IsEnabled = true;
			filters.Add(filterItem);
			structure.Filters.Add(filters);
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

	#region Class: VwSysModuleEntityGridPageEventsProcess

	/// <exclude/>
	public class VwSysModuleEntityGridPageEventsProcess : VwSysModuleEntityGridPageEventsProcess<Terrasoft.WebApp.VwSysModuleEntityGridPageSchemaUserControl>
	{

		public VwSysModuleEntityGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysModuleEntityGridPageSchemaUserControl

	/// <exclude/>
	public partial class VwSysModuleEntityGridPageSchemaUserControl : Terrasoft.WebApp.BaseLookupGridPageSchemaUserControl
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
			var process = (VwSysModuleEntityGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new VwSysModuleEntityGridPageEventsProcess(UserConnection);
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
			SchemaName = "VwSysModuleEntityGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: VwSysModuleEntityGridPageEventsProcessSchema

	/// <exclude/>
	public class VwSysModuleEntityGridPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public VwSysModuleEntityGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwSysModuleEntityGridPageEventsProcessSchema(VwSysModuleEntityGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwSysModuleEntityGridPageEventsProcess";
			UId = new Guid("deae35f7-a162-496e-a3cc-3e134cd173d5");
			CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override ProcessSchemaParameter CreateEditPageUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a676227c-1197-410d-9d09-3e896ddf170d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EditPageUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"b9b78fd8-abb3-439f-9132-fba839de480d",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("deae35f7-a162-496e-a3cc-3e134cd173d5"),
				},
			};
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
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2ec18d58-d5ad-4b15-9d7a-8ac963b89dfd"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("775363c7-62ae-4a8d-b363-4350699b5cf2"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("51e927e4-70cf-41b6-867a-8768292a856e"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
		}

		protected override SchemaMethod CreateGetDeafaultLookupEditSchemaIdMethod() {
			SchemaMethod method = base.CreateGetDeafaultLookupEditSchemaIdMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,47,205,76,209,80,74,178,76,50,183,72,75,177,208,77,76,74,50,214,53,49,182,76,211,181,52,52,54,210,77,75,74,180,48,182,76,73,53,177,48,72,81,210,180,6,0,216,8,189,83,56,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateLoadViewFiltersMethod() {
			SchemaMethod method = base.CreateLoadViewFiltersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,205,79,194,48,20,63,75,194,255,80,119,26,9,212,45,136,209,24,15,56,166,33,49,106,196,143,131,241,80,182,7,86,187,118,190,118,32,33,254,239,182,97,48,62,52,38,30,118,104,223,239,235,189,190,13,153,6,122,165,88,250,200,97,122,193,133,1,212,62,72,54,20,144,150,199,198,105,189,54,97,72,82,102,216,64,21,152,0,57,35,183,108,12,180,183,186,41,33,218,96,145,152,2,127,64,208,168,64,4,105,6,75,72,73,25,45,76,44,161,210,167,23,92,46,221,47,81,21,249,249,236,154,101,224,123,107,33,61,23,139,143,136,191,20,216,63,35,178,16,162,65,230,245,218,222,42,8,45,225,244,14,50,53,129,37,218,145,191,234,181,202,188,34,68,8,204,192,186,251,166,111,147,92,169,49,79,152,184,201,1,153,225,74,218,150,120,98,104,87,166,78,182,106,121,193,136,63,115,4,173,45,142,8,24,153,181,227,174,235,239,92,223,27,204,244,147,194,119,157,179,4,188,63,140,144,143,95,255,237,100,199,39,97,74,212,240,13,18,243,252,50,39,246,98,239,224,192,221,93,22,60,245,189,32,10,218,39,39,71,237,86,212,105,247,90,113,24,134,173,227,78,24,183,130,32,236,116,122,193,97,20,132,61,175,225,88,238,123,208,128,145,146,210,138,89,117,186,234,129,246,83,167,252,213,216,88,132,190,129,204,198,117,102,219,17,253,181,5,25,36,175,144,177,38,185,7,68,166,213,200,208,72,217,222,98,105,184,225,160,203,87,143,84,150,51,228,90,201,251,89,110,171,31,5,19,77,235,185,249,14,205,237,113,185,68,85,26,234,86,207,70,242,186,66,120,155,149,190,142,23,127,138,45,219,249,194,170,170,105,55,77,253,10,233,20,119,87,178,194,216,125,252,6,126,216,218,148,137,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysModuleEntityGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("deae35f7-a162-496e-a3cc-3e134cd173d5"));
		}

		#endregion

	}

	#endregion

}

