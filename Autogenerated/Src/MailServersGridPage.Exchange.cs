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
	using System.Text;
	using System.Threading;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
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

	#region Class: MailServersGridPageSchema

	/// <exclude/>
	public class MailServersGridPageSchema : Terrasoft.WebApp.MailServersGridPage_Base_TerrasoftSchema
	{

		#region Constructors: Public

		public MailServersGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public MailServersGridPageSchema(MailServersGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		private void UpdateCloseButton() {
			CloseButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CloseButton.Image = new ControlImage {};
			CloseButton.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
		}

		private void UpdateControlLayout1() {
			ControlLayout1.Image = new ControlImage {};
			ControlLayout1.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
			Name = "MailServersGridPage";
			ParentSchemaUId = new Guid("e24018bf-4ef6-49ef-a331-4fdb6b742e4c");
			CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMailServersGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateControlLayout1();
			UpdateCloseButton();
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
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.MoveItem(4, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(5, ActionButton);
			ButtonsControlLayout.MoveItem(6, PrintButton);
			ButtonsControlLayout.MoveItem(7, ContextHelpButton);
			TopLevelControl.MoveItem(2, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(3, ControlLayout1);
			ControlLayout1.MoveItem(0, Spacer1);
			ControlLayout1.MoveItem(1, CloseButton);
			TopLevelControl.MoveItem(4, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateMailServersGridPageEventsProcessSchema() {
			var schema = new MailServersGridPageEventsProcessSchema(ProcessSchemaManager, this);
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
				column.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("f0fec10e-c639-4ebb-b0d4-75ba7beb2b30");
			if (column != null) {
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("be4a6212-190c-4430-8b31-6972ac32503f");
			if (column != null) {
				column.IsVisible = false;
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("b9e6dfc3-cd79-4707-9f3d-9b6bedda3c5f");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("773d7c26-389e-421c-a67e-9ca6a8b8a3e9");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("411aaeae-43da-4e1c-8b1c-1655c25aac96");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("6094ebec-dee7-492e-8977-4e2748a9b4bb");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("394009b0-7664-46b4-b052-5754522f03c3");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("33affd30-ab8b-4975-8917-9baa63d2d025");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("c6d3e3b2-5552-4b06-9d5c-fe34b58ae7aa");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("9a6b34c9-96b3-45f5-b005-dfcd12e79d6d");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("89e2b329-bf63-4d5c-a079-6cf6c5fa9430");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("411aaeae-43da-4e1c-8b1c-1655c25aac96");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("411a2310-81f3-4a83-896e-87eccdbae77f");
			if (column != null) {
				column.UId = new Guid("e4dcb193-1856-4747-85be-81354ff3969e");
				column.Name = @"Type";
				column.CreatedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
				column.ModifiedInSchemaUId = new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
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
			return new MailServersGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new MailServersGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("344181c4-ab70-4655-beda-5f7e5df34e82"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new MailServersGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: MailServersGridPageEventsProcess

	/// <exclude/>
	public class MailServersGridPageEventsProcess<TPage> : Terrasoft.WebApp.MailServersGridPage_Base_TerrasoftEventsProcess<TPage> where TPage : Terrasoft.WebApp.MailServersGridPageSchemaUserControl
	{

		public MailServersGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MailServersGridPageEventsProcess";
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("344181c4-ab70-4655-beda-5f7e5df34e82");
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

		private LocalizableString _iMAPMenuItemCaption;
		public LocalizableString IMAPMenuItemCaption {
			get {
				return _iMAPMenuItemCaption ?? (_iMAPMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.IMAPMenuItemCaption.Value"));
			}
		}

		private LocalizableString _exchangeMenuItemCaption;
		public LocalizableString ExchangeMenuItemCaption {
			get {
				return _exchangeMenuItemCaption ?? (_exchangeMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ExchangeMenuItemCaption.Value"));
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

		public override Dictionary<string, string> GetEditPages() {
			TypeColumnUId = new Guid("411A2310-81F3-4A83-896E-87ECCDBAE77F");//column UId in MailServer
			
			var typeEditPageUIds = new Dictionary<Guid, Dictionary<string, Guid>>();
			typeEditPageUIds.Add(new Guid("844F0837-EAA0-4F40-B965-71F5DB9EAE6E"),//"IMAP" Record Id in MailServerType
				new Dictionary <string, Guid>() {
					{"EditPageUId", new Guid("727EC41D-9D34-4095-B1C1-D811DDCF18F3")},
					{"SysModuleEditId", Guid.Empty}
				}
			);
			typeEditPageUIds.Add(new Guid("3490BD45-4F4D-4613-AA06-454546F3342A"),//" Exchange" Record Id in MailServerType
				new Dictionary <string, Guid>() {
					{"EditPageUId", new Guid("9F99ADEC-B1F7-4ED5-98E5-2373B7CD6B13")},
					{"SysModuleEditId", Guid.Empty}
				}
			);
			
			TypeEditPageUIds = typeEditPageUIds;
			
			var listEditPages = new Dictionary <string, string>();
			var key = "727EC41D-9D34-4095-B1C1-D811DDCF18F3&844F0837-EAA0-4F40-B965-71F5DB9EAE6E"; //"IMAP"
			//TODO 
			listEditPages[key] = "IMAP / SMTP";//IMAPMenuItemCaption.Value;
			key = "9F99ADEC-B1F7-4ED5-98E5-2373B7CD6B13&3490BD45-4F4D-4613-AA06-454546F3342A"; //Exchange
			listEditPages[key] = "Microsoft Exchange Web Services";//ExchangeMenuItemCaption.Value;
			return listEditPages;
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

	#region Class: MailServersGridPageEventsProcess

	/// <exclude/>
	public class MailServersGridPageEventsProcess : MailServersGridPageEventsProcess<Terrasoft.WebApp.MailServersGridPageSchemaUserControl>
	{

		public MailServersGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MailServersGridPageSchemaUserControl

	/// <exclude/>
	public partial class MailServersGridPageSchemaUserControl : Terrasoft.WebApp.MailServersGridPage_Base_TerrasoftSchemaUserControl
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
			var process = (MailServersGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new MailServersGridPageEventsProcess(UserConnection);
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
			SchemaName = "MailServersGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: MailServersGridPageEventsProcessSchema

	/// <exclude/>
	public class MailServersGridPageEventsProcessSchema : Terrasoft.WebApp.MailServersGridPage_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public MailServersGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MailServersGridPageEventsProcessSchema(MailServersGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MailServersGridPageEventsProcess";
			UId = new Guid("ee5dd3b8-2e5f-4d24-a868-90fd69cb989f");
			CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a");
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
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateIMAPMenuItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateExchangeMenuItemCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateIMAPMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("90ef457a-af5e-4293-b749-6ed4125c98ec"),
				Name = "IMAPMenuItemCaption",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("ee5dd3b8-2e5f-4d24-a868-90fd69cb989f"),
				ModifiedInSchemaUId = new Guid("ee5dd3b8-2e5f-4d24-a868-90fd69cb989f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateExchangeMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5624eba8-39a3-4a66-ab6a-e8ed63d45c12"),
				Name = "ExchangeMenuItemCaption",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("ee5dd3b8-2e5f-4d24-a868-90fd69cb989f"),
				ModifiedInSchemaUId = new Guid("ee5dd3b8-2e5f-4d24-a868-90fd69cb989f")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("e4d10d65-68f8-4212-8f72-3413dcc307c5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("29f8a308-82f9-44c4-9259-db82adf2062a"),
				CreatedInPackageId = new Guid("008b5e35-cd1d-462d-aec0-4fb9d28e872d"),
				CreatedInSchemaUId = new Guid("ee5dd3b8-2e5f-4d24-a868-90fd69cb989f"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("ee5dd3b8-2e5f-4d24-a868-90fd69cb989f"),
				Name = @"LaneSet1",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("c5937d1b-9b33-4b31-8735-200e8277770e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e4d10d65-68f8-4212-8f72-3413dcc307c5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("008b5e35-cd1d-462d-aec0-4fb9d28e872d"),
				CreatedInSchemaUId = new Guid("ee5dd3b8-2e5f-4d24-a868-90fd69cb989f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ee5dd3b8-2e5f-4d24-a868-90fd69cb989f"),
				Name = @"Lane2",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane2;
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
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("95c66740-e509-4ca4-b1ef-c7a6bb406ec0"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c7fbab2-546c-4dd3-ba02-c8f1ddbc356d"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
		}

		protected override SchemaMethod CreateGetEditPagesMethod() {
			SchemaMethod method = base.CreateGetEditPagesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,147,75,143,155,48,20,133,215,241,175,176,88,140,18,9,7,28,155,151,104,71,2,108,170,44,208,68,13,51,93,84,93,80,112,83,84,2,17,143,105,209,40,255,189,152,76,58,73,70,163,166,139,138,5,194,190,190,231,59,215,135,184,223,137,160,42,186,109,121,191,204,224,123,88,138,159,240,67,151,103,83,133,98,236,45,8,214,145,141,67,130,168,103,19,100,59,38,71,182,197,131,128,249,30,183,172,80,153,185,154,150,142,199,161,60,159,151,48,74,242,98,45,234,71,81,3,240,152,212,176,29,4,120,150,183,171,100,35,134,146,230,89,131,229,105,155,87,101,82,247,239,164,156,122,186,208,180,117,94,110,212,145,227,246,118,58,115,193,101,147,185,151,101,211,23,84,155,210,80,183,137,133,184,231,233,136,134,84,71,190,99,26,200,194,161,193,124,135,123,220,228,202,76,213,52,101,25,121,43,5,126,20,105,85,103,240,18,56,30,84,192,228,156,14,158,211,76,103,240,9,76,38,79,202,9,141,162,158,76,205,90,12,227,161,152,33,135,17,138,168,238,24,200,199,1,70,204,198,152,177,32,196,118,72,148,217,94,29,155,172,251,38,170,178,174,24,189,141,141,100,147,57,223,238,218,126,15,38,123,240,119,235,132,58,186,207,168,33,93,51,68,77,76,208,48,3,19,81,99,120,204,144,16,186,240,14,214,33,255,149,126,79,202,141,248,175,254,157,208,113,60,198,131,193,117,104,33,202,153,129,28,155,27,104,65,44,226,91,1,51,125,252,111,254,65,252,58,64,151,51,113,15,81,43,242,166,61,46,191,206,217,139,147,195,123,12,150,60,246,67,244,67,241,85,55,119,115,85,210,92,120,76,26,208,180,248,142,221,65,112,134,246,121,80,252,34,37,101,13,212,224,58,138,87,202,240,35,201,207,72,148,221,178,21,219,32,217,73,238,249,67,82,116,194,5,207,140,215,76,247,230,170,72,72,198,99,32,222,160,139,242,180,174,154,234,91,251,39,57,240,147,248,10,101,86,242,84,52,146,248,184,241,6,117,45,218,174,46,207,239,197,253,13,95,29,195,63,114,4,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MailServersGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ee5dd3b8-2e5f-4d24-a868-90fd69cb989f"));
		}

		#endregion

	}

	#endregion

}

