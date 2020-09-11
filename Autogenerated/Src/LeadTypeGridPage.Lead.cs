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

	#region Class: LeadTypeGridPageSchema

	/// <exclude/>
	public class LeadTypeGridPageSchema : Terrasoft.WebApp.BaseLookupGridPageSchema
	{

		#region Constructors: Public

		public LeadTypeGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public LeadTypeGridPageSchema(LeadTypeGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
		}

		private void UpdateDownloadTemplateForImportProductsButton() {
			DownloadTemplateForImportProductsButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DownloadTemplateForImportProductsButton.Image = new ControlImage {};
			DownloadTemplateForImportProductsButton.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
		}

		private void UpdateImportProductsButton() {
			ImportProductsButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ImportProductsButton.Image = new ControlImage {};
			ImportProductsButton.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
			RealUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
			Name = "LeadTypeGridPage";
			ParentSchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
			CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLeadTypeGridPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateLeadTypeGridPageEventsProcessSchema() {
			var schema = new LeadTypeGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888");
			DataSource.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("74c3310f-1635-4cc6-bcf6-b89b6330eeb3");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
				column.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("4477faa0-64b0-405e-a164-280c1e625d23");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
				column.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("6477645f-0ab0-40dc-9cf7-ef3bb2761003");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
				column.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("55c9486a-9097-4ffa-aeb0-793424ad4438");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
				column.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("2a779003-5405-4f74-8843-9f5d60a3dacf");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
				column.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("8af6f08d-5d58-435d-8148-8eda54a81d6d");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
				column.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("8ce6c0ed-86e7-4fb9-a777-9698da7b4394");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
				column.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("7a8944fa-b3f0-46dc-8f51-f6b0706106f8");
			if (column != null) {
				column.UId = new Guid("ab0fa5f0-fc6c-4fcc-a779-1c81287b809b");
				column.Name = @"Image";
				column.CreatedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
				column.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("df52f265-1ca8-4803-9d4c-04ebc00af4ce");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
				column.ModifiedInSchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new LeadTypeGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new LeadTypeGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new LeadTypeGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: LeadTypeGridPageEventsProcess

	/// <exclude/>
	public class LeadTypeGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.LeadTypeGridPageSchemaUserControl
	{

		public LeadTypeGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadTypeGridPageEventsProcess";
			SchemaUId = new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("82da457e-650e-4594-b2bf-7fec7e34bdf1");
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

	#region Class: LeadTypeGridPageEventsProcess

	/// <exclude/>
	public class LeadTypeGridPageEventsProcess : LeadTypeGridPageEventsProcess<Terrasoft.WebApp.LeadTypeGridPageSchemaUserControl>
	{

		public LeadTypeGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadTypeGridPageSchemaUserControl

	/// <exclude/>
	public partial class LeadTypeGridPageSchemaUserControl : Terrasoft.WebApp.BaseLookupGridPageSchemaUserControl
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
			var process = (LeadTypeGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new LeadTypeGridPageEventsProcess(UserConnection);
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
			SchemaName = "LeadTypeGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: LeadTypeGridPageEventsProcessSchema

	/// <exclude/>
	public class LeadTypeGridPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public LeadTypeGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LeadTypeGridPageEventsProcessSchema(LeadTypeGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadTypeGridPageEventsProcess";
			UId = new Guid("e81d8377-c114-4dfd-9d47-aa76534b686a");
			CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae");
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
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("775363c7-62ae-4a8d-b363-4350699b5cf2"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("51e927e4-70cf-41b6-867a-8768292a856e"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LeadTypeGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e81d8377-c114-4dfd-9d47-aa76534b686a"));
		}

		#endregion

	}

	#endregion

}

