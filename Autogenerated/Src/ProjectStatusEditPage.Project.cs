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
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.Web.Common;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: ProjectStatusEditPageSchema

	/// <exclude/>
	public class ProjectStatusEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.CheckBox _isFinalEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsFinalEdit {
			get {
				return _isFinalEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public ProjectStatusEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ProjectStatusEditPageSchema(ProjectStatusEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("2fb52373-85b0-4884-95e9-b4be4d2d75a5");
			NameEdit.ModifiedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("8accf06e-fd1b-4551-8882-b0968ed38cf9");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
			RealUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
			Name = "ProjectStatusEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProjectStatusEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateButtonsControlLayout();
			UpdateApplyChangesButton();
			UpdateCancelButton();
			UpdateOKButton();
			UpdateDesignerModeButton();
			UpdateContextHelpButton();
			UpdateMainControlLayout();
			UpdateCustomControls();
			UpdateDescriptionEdit();
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, NameEdit);
			MainControlLayout.InsertItem(1, CreateIsFinalEdit());
			MainControlLayout.MoveItem(2, DescriptionEdit);
			MainControlLayout.MoveItem(3, CustomControls);
			TopLevelControl.MoveItem(2, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, ContextHelpButton);
			ButtonsControlLayout.MoveItem(1, DesignerModeButton);
			ButtonsControlLayout.MoveItem(2, SpacerButton);
			ButtonsControlLayout.MoveItem(3, OKButton);
			ButtonsControlLayout.MoveItem(4, CancelButton);
			ButtonsControlLayout.MoveItem(5, ApplyChangesButton);
			TopLevelControl.MoveItem(3, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateProjectStatusEditPageEventsProcessSchema() {
			var schema = new ProjectStatusEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsFinalEdit() {
			_isFinalEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isFinalEdit.UId = new Guid("f0df1a03-ad0f-41dd-8d74-92169e9589e2");
			_isFinalEdit.Name = "IsFinalEdit";
			_isFinalEdit.CreatedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
			_isFinalEdit.ModifiedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
			_isFinalEdit.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			_isFinalEdit.Tag = "";
			_isFinalEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isFinalEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isFinalEdit.DataSource = "DataSource";
			_isFinalEdit.ColumnUId = new Guid("2072a2fe-fa9d-4f73-a82c-8a4b8fdb1637");
			return _isFinalEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("8bafd341-8ae7-4703-bca6-8de07c992d37");
			DataSource.ModifiedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("4390f8f2-23e9-417b-8af7-7e9125ceb59c");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
				column.ModifiedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("edeccac1-93f2-4024-9877-6c89ed72bfdb");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
				column.ModifiedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("10011f75-2b78-453b-898c-d46796d63e79");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
				column.ModifiedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("c5d0c228-6a94-44c3-9f1b-ba6de5aa9202");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
				column.ModifiedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("d2e9f748-de64-4630-ad61-a1fed480d3d9");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
				column.ModifiedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("2fb52373-85b0-4884-95e9-b4be4d2d75a5");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
				column.ModifiedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("8accf06e-fd1b-4551-8882-b0968ed38cf9");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
				column.ModifiedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("755b4b2d-30c0-4028-bc2a-589d37ec6d70");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
				column.ModifiedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("d133f56e-288a-4ce7-93c5-b84b02ebe33a");
			if (column != null) {
				column.UId = new Guid("2072a2fe-fa9d-4f73-a82c-8a4b8fdb1637");
				column.Name = @"IsFinal";
				column.CreatedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
				column.ModifiedInSchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
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
			return new ProjectStatusEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ProjectStatusEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ProjectStatusEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ProjectStatusEditPageEventsProcess

	/// <exclude/>
	public class ProjectStatusEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ProjectStatusEditPageSchemaUserControl
	{

		public ProjectStatusEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProjectStatusEditPageEventsProcess";
			SchemaUId = new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c17ec90a-710f-4e79-a9b9-c4290ae89ede");
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

	#region Class: ProjectStatusEditPageEventsProcess

	/// <exclude/>
	public class ProjectStatusEditPageEventsProcess : ProjectStatusEditPageEventsProcess<Terrasoft.WebApp.ProjectStatusEditPageSchemaUserControl>
	{

		public ProjectStatusEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProjectStatusEditPageSchemaUserControl

	/// <exclude/>
	public partial class ProjectStatusEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.CheckBox IsFinalEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsFinalEdit", true);
			}
		}

		#endregion

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
			var process = (ProjectStatusEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ProjectStatusEditPageEventsProcess(UserConnection);
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
			SchemaName = "ProjectStatusEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ProjectStatusEditPageEventsProcessSchema

	/// <exclude/>
	public class ProjectStatusEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ProjectStatusEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ProjectStatusEditPageEventsProcessSchema(ProjectStatusEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ProjectStatusEditPageEventsProcess";
			UId = new Guid("04133177-bbb3-42d0-a76b-691ded692e5b");
			CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b");
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
				UId = new Guid("b22cedfd-39cd-46e5-b5c4-6f7cd276eb74"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProjectStatusEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("04133177-bbb3-42d0-a76b-691ded692e5b"));
		}

		#endregion

	}

	#endregion

}

