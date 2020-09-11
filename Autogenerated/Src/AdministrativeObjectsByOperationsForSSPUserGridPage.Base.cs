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
	using System.Linq;
	using System.Security;
	using System.Text;
	using System.Threading;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.OperationLog;
	using Terrasoft.Core.Packages;
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

	#region Class: AdministrativeObjectsByOperationsForSSPUserGridPageSchema

	/// <exclude/>
	public class AdministrativeObjectsByOperationsForSSPUserGridPageSchema : Terrasoft.WebApp.AdministrativeObjectsByOperationsGridPageSchema
	{

		#region Constructors: Public

		public AdministrativeObjectsByOperationsForSSPUserGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AdministrativeObjectsByOperationsForSSPUserGridPageSchema(AdministrativeObjectsByOperationsForSSPUserGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
		}

		private void UpdateUpButton() {
			UpButton.AjaxEvents.Click.IsProcessEventHandler = true;
			UpButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45"),
				ImageHash = @"237f430c77240f66f9368acf2476bfc0"
			};
			UpButton.ModifiedInSchemaUId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
		}

		private void UpdateDownButton() {
			DownButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DownButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45"),
				ImageHash = @"237f430c77240f66f9368acf2476bfc0"
			};
			DownButton.ModifiedInSchemaUId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
		}

		private void UpdateShowRelatedRightsCheckBox() {
			ShowRelatedRightsCheckBox.AjaxEvents.Check.IsProcessEventHandler = true;
		}

		private void UpdateCheckBoxControlLayout() {
			CheckBoxControlLayout.Image = new ControlImage {};
			CheckBoxControlLayout.ModifiedInSchemaUId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
		}

		private void UpdateOwnMenuItem() {
			OwnMenuItem.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			OwnMenuItem.AjaxEvents.CheckChange.ShowLoadMask = true;
			OwnMenuItem.Image = new ControlImage {};
			OwnMenuItem.ModifiedInSchemaUId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
		}

		private void UpdateAllMenuItem() {
			AllMenuItem.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			AllMenuItem.AjaxEvents.CheckChange.ShowLoadMask = true;
			AllMenuItem.Image = new ControlImage {};
			AllMenuItem.ModifiedInSchemaUId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
		}

		private void UpdateShowRelatedRightsButton() {
			ShowRelatedRightsButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1"),
				ImageHash = @"57f7aae3209afa943cac8813eca36f32"
			};
			ShowRelatedRightsButton.ModifiedInSchemaUId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
			TreeGrid.AjaxEvents.SelectionChange.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
			RealUId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
			Name = "AdministrativeObjectsByOperationsForSSPUserGridPage";
			ParentSchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
			CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdministrativeObjectsByOperationsForSSPUserGridPageEventsProcessSchema();
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
			UpdateContextHelpButton();
			UpdateShowRelatedRightsButton();
			UpdateAllMenuItem();
			UpdateOwnMenuItem();
			UpdatePrintButton();
			UpdateCheckBoxControlLayout();
			UpdateShowRelatedRightsCheckBox();
			UpdateDownButton();
			UpdateUpButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			TopLevelControl.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.MoveItem(4, UpButton);
			ButtonsControlLayout.MoveItem(5, DownButton);
			ButtonsControlLayout.MoveItem(6, CheckBoxControlLayout);
			CheckBoxControlLayout.MoveItem(0, ShowRelatedRightsCheckBox);
			ButtonsControlLayout.MoveItem(7, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(8, PrintButton);
			ButtonsControlLayout.MoveItem(9, ShowRelatedRightsButton);
			ShowRelatedRightsButton.MoveItem(0, OwnMenuItem);
			ShowRelatedRightsButton.MoveItem(1, AllMenuItem);
			ButtonsControlLayout.MoveItem(10, ContextHelpButton);
			ButtonsControlLayout.MoveItem(11, ActionButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateAdministrativeObjectsByOperationsForSSPUserGridPageEventsProcessSchema() {
			var schema = new AdministrativeObjectsByOperationsForSSPUserGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.Columns.FindByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.IsVisible = false;
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("d27e9964-a7a6-46dd-9f9a-7cb470c33b98");
			if (column != null) {
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new AdministrativeObjectsByOperationsForSSPUserGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new AdministrativeObjectsByOperationsForSSPUserGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AdministrativeObjectsByOperationsForSSPUserGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeObjectsByOperationsForSSPUserGridPageEventsProcess

	/// <exclude/>
	public class AdministrativeObjectsByOperationsForSSPUserGridPageEventsProcess<TPage> : Terrasoft.WebApp.AdministrativeObjectsByOperationsGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AdministrativeObjectsByOperationsForSSPUserGridPageSchemaUserControl
	{

		public AdministrativeObjectsByOperationsForSSPUserGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdministrativeObjectsByOperationsForSSPUserGridPageEventsProcess";
			SchemaUId = new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6f03e300-3e9d-410b-bd77-75413ae4f01a");
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

		public override void ChangeRightItemPosition(Guid primaryColumnValue, int position, bool increasePosition, string subjectSchema) {
			base.ChangeRightItemPosition(primaryColumnValue, position, increasePosition, subjectSchema);
			OperationLogger.Instance.LogEntitySchemaOperationRightEdit(UserConnection, primaryColumnValue);
		}

		public override Select GetSelectForVirtualDataSource(params object[] objectParameters) {
			var select = base.GetSelectForVirtualDataSource(objectParameters);
			select.And("SysAdminUnit", "ConnectionType").IsEqual(Column.Parameter(UserType.SSP));
			return select;
		}

		public override void SetIsAdministratedByOperations() {
			Select select =
							new Select(UserConnection)
								.Column(Column.Const(1))
								.From("VwAdministrativeObjects")
									.InnerJoin("SysSSPEntitySchemaAccessList").On("SysSSPEntitySchemaAccessList", "EntitySchemaUId")
										.IsEqual("VwAdministrativeObjects", "UId")
								.Where("VwAdministrativeObjects", "Id")
									.IsEqual(Column.Parameter(SelectedNodePrimaryColumnValue))
								.And("VwAdministrativeObjects", "SysWorkspaceId").IsEqual(Column.Parameter(Page.UserConnection.Workspace.Id))
								.And("VwAdministrativeObjects", "AdministratedByOperations").IsEqual(Column.Parameter(false))as Select;
						using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
							using (var dataReader = select.ExecuteReader(dbExecutor)) {
								IsOperationAdministrated = dataReader.Read();
							}
						}
		}

		public override Guid GetLookupUserTaskSchemaUId() {
			return new Guid("f1216816-1e84-4057-8803-1710de78c14c");
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

	#region Class: AdministrativeObjectsByOperationsForSSPUserGridPageEventsProcess

	/// <exclude/>
	public class AdministrativeObjectsByOperationsForSSPUserGridPageEventsProcess : AdministrativeObjectsByOperationsForSSPUserGridPageEventsProcess<Terrasoft.WebApp.AdministrativeObjectsByOperationsForSSPUserGridPageSchemaUserControl>
	{

		public AdministrativeObjectsByOperationsForSSPUserGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdministrativeObjectsByOperationsForSSPUserGridPageSchemaUserControl

	/// <exclude/>
	public partial class AdministrativeObjectsByOperationsForSSPUserGridPageSchemaUserControl : Terrasoft.WebApp.AdministrativeObjectsByOperationsGridPageSchemaUserControl
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
			var process = (AdministrativeObjectsByOperationsForSSPUserGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AdministrativeObjectsByOperationsForSSPUserGridPageEventsProcess(UserConnection);
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
			SchemaName = "AdministrativeObjectsByOperationsForSSPUserGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeObjectsByOperationsForSSPUserGridPageEventsProcessSchema

	/// <exclude/>
	public class AdministrativeObjectsByOperationsForSSPUserGridPageEventsProcessSchema : Terrasoft.WebApp.AdministrativeObjectsByOperationsGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public AdministrativeObjectsByOperationsForSSPUserGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdministrativeObjectsByOperationsForSSPUserGridPageEventsProcessSchema(AdministrativeObjectsByOperationsForSSPUserGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdministrativeObjectsByOperationsForSSPUserGridPageEventsProcess";
			UId = new Guid("6fa926f5-d334-447d-a3c1-315fb0b0aa7b");
			CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06");
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
				UId = new Guid("9d7efbbf-8549-484c-9592-82bf90843f5d"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("95c66740-e509-4ca4-b1ef-c7a6bb406ec0"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c7fbab2-546c-4dd3-ba02-c8f1ddbc356d"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("57e43cd6-21b8-4cf0-8269-102825ad68c4"),
				Name = "Terrasoft.Core.OperationLog",
				Alias = "",
				CreatedInPackageId = new Guid("0bea0088-e6a2-4f3a-b02e-e01a15923e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4cb6d400-f8bb-48de-a251-d01086f4fa90"),
				Name = "System.Security",
				Alias = "",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f6d0c1c0-59dd-466d-9521-afefd098b9ec"),
				Name = "Terrasoft.Core.Packages",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected override SchemaMethod CreateChangeRightItemPositionMethod() {
			SchemaMethod method = base.CreateChangeRightItemPositionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,177,10,195,48,16,67,247,126,69,198,4,130,127,32,163,201,16,40,52,180,180,251,197,61,236,43,241,217,216,231,33,127,95,55,45,89,58,74,122,18,90,32,163,210,14,216,226,149,172,147,73,208,207,33,147,80,224,54,38,242,144,54,29,214,226,249,1,107,193,190,137,191,176,111,136,77,194,90,159,15,39,151,229,133,70,110,198,161,135,110,56,93,34,38,248,68,231,96,45,38,53,113,22,96,131,170,234,145,133,100,251,162,7,183,95,24,159,36,237,61,99,210,129,185,206,237,211,255,87,186,225,13,168,121,63,220,188,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetSelectForVirtualDataSourceMethod() {
			SchemaMethod method = base.CreateGetSelectForVirtualDataSourceMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,61,142,59,10,195,48,16,68,251,156,66,168,146,32,232,2,38,133,113,62,164,51,40,78,191,182,183,80,144,87,201,106,21,240,237,163,124,72,59,111,230,49,79,96,149,49,226,36,106,167,70,200,232,78,40,254,19,28,19,95,3,75,129,184,7,1,159,10,79,104,210,120,171,168,7,134,5,5,57,219,102,243,157,187,150,102,163,253,154,219,121,9,52,80,16,189,85,186,75,68,21,134,68,151,245,142,218,186,115,62,60,170,209,116,41,150,133,220,95,100,134,140,252,238,56,239,123,91,173,140,82,152,126,223,154,23,253,187,245,138,167,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateSetIsAdministratedByOperationsMethod() {
			SchemaMethod method = base.CreateSetIsAdministratedByOperationsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,79,195,48,12,61,151,95,81,245,148,74,40,18,103,180,195,62,138,84,132,88,69,181,237,236,53,102,11,180,201,136,211,141,10,237,191,147,126,208,117,72,27,228,16,39,182,223,123,182,147,20,115,204,172,79,173,25,221,120,110,41,60,248,105,227,96,11,66,51,213,74,185,179,212,42,108,194,30,159,234,188,44,20,107,141,187,41,178,236,46,252,137,62,24,93,176,96,121,24,139,66,42,73,214,128,149,123,156,175,223,28,9,5,93,150,199,99,199,106,30,181,84,44,72,43,74,211,36,82,86,218,42,205,182,88,192,56,203,144,232,201,161,131,144,207,255,74,185,245,131,97,100,17,139,94,198,233,80,244,81,66,126,185,34,135,30,32,248,106,139,6,175,102,15,232,123,246,110,22,9,24,40,208,162,97,237,0,81,60,107,129,137,145,5,152,170,205,89,66,94,98,63,172,177,18,87,181,92,223,43,109,222,105,7,25,214,186,151,5,19,216,32,63,127,47,222,67,121,44,254,45,57,8,160,152,84,243,29,214,41,238,145,175,169,191,66,78,174,43,160,238,231,220,215,98,37,73,181,241,217,108,18,125,98,86,90,109,124,177,238,143,35,255,87,177,145,162,210,224,108,114,114,177,48,244,191,154,170,59,166,61,56,10,176,240,130,32,176,166,104,255,45,111,73,177,117,179,147,72,143,247,98,234,251,56,235,207,113,156,8,121,109,88,216,212,238,29,235,253,248,13,92,244,224,215,32,3,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetLookupUserTaskSchemaUIdMethod() {
			SchemaMethod method = base.CreateGetLookupUserTaskSchemaUIdMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,47,205,76,209,80,74,51,52,50,52,179,48,52,211,53,76,181,48,209,53,49,48,53,215,181,176,48,48,214,53,52,55,52,72,73,53,183,72,54,52,73,86,210,180,6,0,166,236,216,142,56,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AdministrativeObjectsByOperationsForSSPUserGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6fa926f5-d334-447d-a3c1-315fb0b0aa7b"));
		}

		#endregion

	}

	#endregion

}

