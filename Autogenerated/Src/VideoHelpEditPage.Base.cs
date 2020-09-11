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

	#region Class: VideoHelpEditPageSchema

	/// <exclude/>
	public class VideoHelpEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _nameEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return _nameEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _helpContextIdEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit HelpContextIdEdit {
			get {
				return _helpContextIdEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _videoCodeEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit VideoCodeEdit {
			get {
				return _videoCodeEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public VideoHelpEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public VideoHelpEditPageSchema(VideoHelpEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
			RealUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
			Name = "VideoHelpEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 200;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVideoHelpEditPageEventsProcessSchema();
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
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.InsertItem(0, CreateNameEdit());
			MainControlLayout.InsertItem(1, CreateHelpContextIdEdit());
			MainControlLayout.InsertItem(2, CreateVideoCodeEdit());
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

		protected virtual EmbeddedProcessSchema CreateVideoHelpEditPageEventsProcessSchema() {
			var schema = new VideoHelpEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateNameEdit() {
			_nameEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_nameEdit.UId = new Guid("654629b2-254c-4985-844b-e217db0aa1d1");
			_nameEdit.Name = "NameEdit";
			_nameEdit.CreatedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
			_nameEdit.ModifiedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
			_nameEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_nameEdit.Tag = "";
			_nameEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_nameEdit.Image = new ControlImage {};
			_nameEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_nameEdit.DataSource = "DataSource";
			_nameEdit.ColumnUId = new Guid("17875ae2-5ed7-4ed9-aeea-eafdf43d4a63");
			return _nameEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateHelpContextIdEdit() {
			_helpContextIdEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_helpContextIdEdit.UId = new Guid("1ce72659-f6bb-49bb-bea6-fe28444f28c7");
			_helpContextIdEdit.Name = "HelpContextIdEdit";
			_helpContextIdEdit.CreatedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
			_helpContextIdEdit.ModifiedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
			_helpContextIdEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_helpContextIdEdit.Tag = "";
			_helpContextIdEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_helpContextIdEdit.Image = new ControlImage {};
			_helpContextIdEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_helpContextIdEdit.DataSource = "DataSource";
			_helpContextIdEdit.ColumnUId = new Guid("87f0d86b-2fa3-4000-a1ea-c1863ae0dc30");
			return _helpContextIdEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateVideoCodeEdit() {
			_videoCodeEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_videoCodeEdit.UId = new Guid("06196b75-05ae-4153-a2a0-5c2fe254f21b");
			_videoCodeEdit.Name = "VideoCodeEdit";
			_videoCodeEdit.CreatedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
			_videoCodeEdit.ModifiedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
			_videoCodeEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_videoCodeEdit.Tag = "";
			_videoCodeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_videoCodeEdit.Image = new ControlImage {};
			_videoCodeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_videoCodeEdit.DataSource = "DataSource";
			_videoCodeEdit.ColumnUId = new Guid("580ecab2-bf45-467d-963a-5becf8272bb3");
			return _videoCodeEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("66b8a34c-fc3d-4950-adcf-2a44cc8e455b");
			DataSource.ModifiedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("79633681-cb37-4654-90d9-3ea71fcf9ec6");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
				column.ModifiedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("17875ae2-5ed7-4ed9-aeea-eafdf43d4a63");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
				column.ModifiedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("a78a0378-7a37-4eb9-9b51-9325adef9ae0");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
				column.ModifiedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("ef9af2e3-a80d-4285-914b-11c6dec57c20");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
				column.ModifiedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("e1f6c98b-bf68-40aa-b68a-81c377ac20da");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
				column.ModifiedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("6183424e-de98-43c6-93e6-0bdd8c2ffc79");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
				column.ModifiedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("b5a5cd5b-25a2-4f00-a89a-50d8ca0c380e");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
				column.ModifiedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("6326f82f-fa54-4bf7-835a-9126054263df");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
				column.ModifiedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c12211f7-6342-4ca3-969a-908e3232a9cc");
			if (column != null) {
				column.UId = new Guid("87f0d86b-2fa3-4000-a1ea-c1863ae0dc30");
				column.Name = @"HelpContextId";
				column.CreatedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
				column.ModifiedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("87009f4d-8af9-4813-8179-28b579187805");
			if (column != null) {
				column.UId = new Guid("580ecab2-bf45-467d-963a-5becf8272bb3");
				column.Name = @"VideoCode";
				column.CreatedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
				column.ModifiedInSchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
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
			return new VideoHelpEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new VideoHelpEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("692a1a2c-adaf-4708-9440-8d9f446343da"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new VideoHelpEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: VideoHelpEditPageEventsProcess

	/// <exclude/>
	public class VideoHelpEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.VideoHelpEditPageSchemaUserControl
	{

		public VideoHelpEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VideoHelpEditPageEventsProcess";
			SchemaUId = new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("692a1a2c-adaf-4708-9440-8d9f446343da");
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

	#region Class: VideoHelpEditPageEventsProcess

	/// <exclude/>
	public class VideoHelpEditPageEventsProcess : VideoHelpEditPageEventsProcess<Terrasoft.WebApp.VideoHelpEditPageSchemaUserControl>
	{

		public VideoHelpEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VideoHelpEditPageSchemaUserControl

	/// <exclude/>
	public partial class VideoHelpEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("NameEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit HelpContextIdEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("HelpContextIdEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit VideoCodeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("VideoCodeEdit", true);
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
			var process = (VideoHelpEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new VideoHelpEditPageEventsProcess(UserConnection);
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
			SchemaName = "VideoHelpEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: VideoHelpEditPageEventsProcessSchema

	/// <exclude/>
	public class VideoHelpEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public VideoHelpEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VideoHelpEditPageEventsProcessSchema(VideoHelpEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VideoHelpEditPageEventsProcess";
			UId = new Guid("ed29705f-17c0-49be-ab4b-8fe49e9258bc");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1");
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
				UId = new Guid("b22cedfd-39cd-46e5-b5c4-6f7cd276eb74"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VideoHelpEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ed29705f-17c0-49be-ab4b-8fe49e9258bc"));
		}

		#endregion

	}

	#endregion

}

