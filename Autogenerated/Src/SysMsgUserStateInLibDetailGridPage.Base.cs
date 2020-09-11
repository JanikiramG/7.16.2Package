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
	using System.Threading;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
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
	using WebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: SysMsgUserStateInLibDetailGridPageSchema

	/// <exclude/>
	public class SysMsgUserStateInLibDetailGridPageSchema : Terrasoft.WebApp.BaseManyToManyDetailGridPageSchema
	{

		#region Constructors: Public

		public SysMsgUserStateInLibDetailGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysMsgUserStateInLibDetailGridPageSchema(SysMsgUserStateInLibDetailGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				ImageHash = @""
			};
			CopyButton.ModifiedInSchemaUId = new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
			RealUId = new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
			Name = "SysMsgUserStateInLibDetailGridPage";
			ParentSchemaUId = new Guid("bb5ab5ef-40b7-45f6-b503-17afaa6584a0");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysMsgUserStateInLibDetailGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendTemplateEmailMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateContextHelpButton();
			UpdatePrintButton();
			UpdateActionButton();
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
			ButtonsControlLayout.MoveItem(5, ActionButton);
			ButtonsControlLayout.MoveItem(6, PrintButton);
			ButtonsControlLayout.MoveItem(7, ContextHelpButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysMsgUserStateInLibDetailGridPageEventsProcessSchema() {
			var schema = new SysMsgUserStateInLibDetailGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("da807457-7105-4735-84f0-8915c70fe5bf");
			DataSource.ModifiedInSchemaUId = new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("c10201fc-cfb1-44f1-94c8-1c91c0f4e9d6");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
				column.ModifiedInSchemaUId = new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("d12bbe21-ad0a-4533-9df4-b70e9fcaf440");
			if (column != null) {
				column.UId = new Guid("8fb6b65c-4497-4cb4-a725-2cf78a60d613");
				column.Name = @"SysMsgUserState";
				column.CreatedInSchemaUId = new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
				column.ModifiedInSchemaUId = new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c8b8a0a3-cd6a-402d-8916-091e2b69a857");
			if (column != null) {
				column.UId = new Guid("bf5b3fef-1b93-499e-98d2-35e8f9cd0208");
				column.Name = @"SysMsgLib";
				column.CreatedInSchemaUId = new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
				column.ModifiedInSchemaUId = new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
				column.CreatedInPackageId = Guid.Empty;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SysMsgUserStateInLibDetailGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysMsgUserStateInLibDetailGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysMsgUserStateInLibDetailGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysMsgUserStateInLibDetailGridPageEventsProcess

	/// <exclude/>
	public class SysMsgUserStateInLibDetailGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseManyToManyDetailGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysMsgUserStateInLibDetailGridPageSchemaUserControl
	{

		public SysMsgUserStateInLibDetailGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysMsgUserStateInLibDetailGridPageEventsProcess";
			SchemaUId = new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ce04fc5a-1ee6-4607-ae57-cc97ff88944a");
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

		public override string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			if (IsEntityDetail) {
				return base.GetRegisterEditPageScript(editPageUId, sysModuleEditId);
			} else {
				return string.Empty;
			}
		}

		public override string GetRegisterAddPageScript(Guid editPageUId, Guid sysModuleEditId, Guid typeId) {
			if (IsEntityDetail) {
				return base.GetRegisterAddPageScript(editPageUId, sysModuleEditId, typeId);
			} else {
				Page.AddButton.AjaxEvents.Click.SignalName = "AddButtonClick";
				return string.Empty;
			}
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

	#region Class: SysMsgUserStateInLibDetailGridPageEventsProcess

	/// <exclude/>
	public class SysMsgUserStateInLibDetailGridPageEventsProcess : SysMsgUserStateInLibDetailGridPageEventsProcess<Terrasoft.WebApp.SysMsgUserStateInLibDetailGridPageSchemaUserControl>
	{

		public SysMsgUserStateInLibDetailGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysMsgUserStateInLibDetailGridPageSchemaUserControl

	/// <exclude/>
	public partial class SysMsgUserStateInLibDetailGridPageSchemaUserControl : Terrasoft.WebApp.BaseManyToManyDetailGridPageSchemaUserControl
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
			var process = (SysMsgUserStateInLibDetailGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysMsgUserStateInLibDetailGridPageEventsProcess(UserConnection);
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
			SchemaName = "SysMsgUserStateInLibDetailGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysMsgUserStateInLibDetailGridPageEventsProcessSchema

	/// <exclude/>
	public class SysMsgUserStateInLibDetailGridPageEventsProcessSchema : Terrasoft.WebApp.BaseManyToManyDetailGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysMsgUserStateInLibDetailGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysMsgUserStateInLibDetailGridPageEventsProcessSchema(SysMsgUserStateInLibDetailGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysMsgUserStateInLibDetailGridPageEventsProcess";
			UId = new Guid("eea577ff-91be-46ba-95b3-477a1446fdb5");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048");
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
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e166c122-42fa-4f50-991f-89f6d5e40e3c"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateGetRegisterEditPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterEditPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,240,44,118,205,43,201,44,169,116,73,45,73,204,204,209,84,168,230,229,226,44,74,45,41,45,202,83,72,74,44,78,213,115,79,45,9,74,77,207,44,46,73,45,114,77,201,44,9,72,76,79,13,78,46,202,44,40,209,72,133,114,67,61,83,116,20,138,43,139,125,243,83,74,115,82,65,138,60,83,52,173,121,185,106,21,82,115,138,83,145,13,44,46,41,202,204,75,215,115,205,45,40,169,4,41,0,0,27,204,239,221,128,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterAddPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterAddPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,61,142,65,10,194,48,16,69,215,246,20,161,171,22,36,23,40,46,170,6,233,66,17,139,7,136,205,24,70,211,180,100,166,98,16,239,110,227,162,203,255,255,227,241,241,46,138,134,148,103,228,184,7,214,232,74,241,201,86,1,120,10,94,220,52,129,60,0,95,192,34,49,132,218,152,179,182,208,118,1,71,46,192,32,167,120,109,204,90,80,164,227,96,38,7,106,110,83,193,113,132,198,148,85,246,21,224,8,146,53,193,114,118,108,39,230,193,203,250,161,223,234,5,158,73,238,28,118,79,217,162,245,218,157,116,15,98,35,242,5,252,143,121,181,188,34,14,232,173,84,253,200,113,214,255,0,77,63,40,24,195,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysMsgUserStateInLibDetailGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eea577ff-91be-46ba-95b3-477a1446fdb5"));
		}

		#endregion

	}

	#endregion

}

