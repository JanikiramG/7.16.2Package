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
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Web;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration.ProjectService;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Activity_Project_TerrasoftSchema

	/// <exclude/>
	public class Activity_Project_TerrasoftSchema : Terrasoft.Configuration.Activity_CoreContracts_TerrasoftSchema
	{

		#region Constructors: Public

		public Activity_Project_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Activity_Project_TerrasoftSchema(Activity_Project_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Activity_Project_TerrasoftSchema(Activity_Project_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIX_Activity_SendDateIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("1e60c588-1264-4219-9f83-2a3e68bc54b6");
			index.Name = "IX_Activity_SendDate";
			index.CreatedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d");
			index.ModifiedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d");
			index.CreatedInPackageId = new Guid("d931fb95-07c0-4237-ab9a-64ecf34e5aed");
			EntitySchemaIndexColumn sendDateIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("b8f4292f-5ae6-43ca-9685-1301b31eba68"),
				ColumnUId = new Guid("6689a019-c904-4b25-a89d-d17f3f3767cc"),
				CreatedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d"),
				ModifiedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d"),
				CreatedInPackageId = new Guid("d931fb95-07c0-4237-ab9a-64ecf34e5aed"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(sendDateIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			Name = "Activity_Project_Terrasoft";
			ParentSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			ExtendParent = true;
			CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e2d77c79-645a-450c-b4bd-0bbf55588489")) == null) {
				Columns.Add(CreateProjectColumn());
			}
			if (Columns.FindByUId(new Guid("a07b44ec-9d82-4c14-a5a6-a7bc4a1c9354")) == null) {
				Columns.Add(CreateFullProjectNameColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateTitleColumn() {
			EntitySchemaColumn column = base.CreateTitleColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateStartDateColumn() {
			EntitySchemaColumn column = base.CreateStartDateColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateDueDateColumn() {
			EntitySchemaColumn column = base.CreateDueDateColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreatePriorityColumn() {
			EntitySchemaColumn column = base.CreatePriorityColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateAuthorColumn() {
			EntitySchemaColumn column = base.CreateAuthorColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateRemindToAuthorColumn() {
			EntitySchemaColumn column = base.CreateRemindToAuthorColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateRemindToAuthorDateColumn() {
			EntitySchemaColumn column = base.CreateRemindToAuthorDateColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateOwnerColumn() {
			EntitySchemaColumn column = base.CreateOwnerColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateRemindToOwnerColumn() {
			EntitySchemaColumn column = base.CreateRemindToOwnerColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateRemindToOwnerDateColumn() {
			EntitySchemaColumn column = base.CreateRemindToOwnerDateColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateTypeColumn() {
			EntitySchemaColumn column = base.CreateTypeColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateActivityCategoryColumn() {
			EntitySchemaColumn column = base.CreateActivityCategoryColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateShowInSchedulerColumn() {
			EntitySchemaColumn column = base.CreateShowInSchedulerColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateStatusColumn() {
			EntitySchemaColumn column = base.CreateStatusColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateResultColumn() {
			EntitySchemaColumn column = base.CreateResultColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateDetailedResultColumn() {
			EntitySchemaColumn column = base.CreateDetailedResultColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateTimeZoneColumn() {
			EntitySchemaColumn column = base.CreateTimeZoneColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateAccountColumn() {
			EntitySchemaColumn column = base.CreateAccountColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateContactColumn() {
			EntitySchemaColumn column = base.CreateContactColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateSenderColumn() {
			EntitySchemaColumn column = base.CreateSenderColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateRecepientColumn() {
			EntitySchemaColumn column = base.CreateRecepientColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateCopyRecepientColumn() {
			EntitySchemaColumn column = base.CreateCopyRecepientColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateBlindCopyRecepientColumn() {
			EntitySchemaColumn column = base.CreateBlindCopyRecepientColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateBodyColumn() {
			EntitySchemaColumn column = base.CreateBodyColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateNotesColumn() {
			EntitySchemaColumn column = base.CreateNotesColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateColorColumn() {
			EntitySchemaColumn column = base.CreateColorColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateSendDateColumn() {
			EntitySchemaColumn column = base.CreateSendDateColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateEmailSendStatusColumn() {
			EntitySchemaColumn column = base.CreateEmailSendStatusColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateDurationInMinutesColumn() {
			EntitySchemaColumn column = base.CreateDurationInMinutesColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateErrorOnSendColumn() {
			EntitySchemaColumn column = base.CreateErrorOnSendColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateDurationInMnutesAndHoursColumn() {
			EntitySchemaColumn column = base.CreateDurationInMnutesAndHoursColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateAllowedResultColumn() {
			EntitySchemaColumn column = base.CreateAllowedResultColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByInvCRMColumn() {
			EntitySchemaColumn column = base.CreateCreatedByInvCRMColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateMessageTypeColumn() {
			EntitySchemaColumn column = base.CreateMessageTypeColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateIsHtmlBodyColumn() {
			EntitySchemaColumn column = base.CreateIsHtmlBodyColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateMailHashColumn() {
			EntitySchemaColumn column = base.CreateMailHashColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessElementIdColumn() {
			EntitySchemaColumn column = base.CreateProcessElementIdColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateOpportunityColumn() {
			EntitySchemaColumn column = base.CreateOpportunityColumn();
			column.IsTrackChangesInDB = true;
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateLeadColumn() {
			EntitySchemaColumn column = base.CreateLeadColumn();
			column.ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected virtual EntitySchemaColumn CreateProjectColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e2d77c79-645a-450c-b4bd-0bbf55588489"),
				Name = @"Project",
				ReferenceSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517"),
				ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517"),
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			};
		}

		protected virtual EntitySchemaColumn CreateFullProjectNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("a07b44ec-9d82-4c14-a5a6-a7bc4a1c9354"),
				Name = @"FullProjectName",
				CreatedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517"),
				ModifiedInSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517"),
				CreatedInPackageId = new Guid("61c8641f-c044-4b81-ab30-bcda839818c3")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIX_Activity_SendDateIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateActivity_Project_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateActivity_Project_TerrasoftEventsProcessSchema() {
			var schema = new Activity_Project_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Activity_Project_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Activity_ProjectEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Activity_Project_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Activity_Project_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5d2e238c-305a-4610-927c-ede2a53ca517"));
		}

		#endregion

	}

	#endregion

	#region Class: Activity_Project_Terrasoft

	/// <summary>
	/// Activity.
	/// </summary>
	public class Activity_Project_Terrasoft : Terrasoft.Configuration.Activity_CoreContracts_Terrasoft
	{

		#region Constructors: Public

		public Activity_Project_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Activity_Project_Terrasoft";
		}

		public Activity_Project_Terrasoft(Activity_Project_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ProjectId {
			get {
				return GetTypedColumnValue<Guid>("ProjectId");
			}
			set {
				SetColumnValue("ProjectId", value);
				_project = null;
			}
		}

		/// <exclude/>
		public string ProjectName {
			get {
				return GetTypedColumnValue<string>("ProjectName");
			}
			set {
				SetColumnValue("ProjectName", value);
				if (_project != null) {
					_project.Name = value;
				}
			}
		}

		private Project _project;
		/// <summary>
		/// Project.
		/// </summary>
		public Project Project {
			get {
				return _project ??
					(_project = LookupColumnEntities.GetEntity("Project") as Project);
			}
		}

		/// <summary>
		/// Project.
		/// </summary>
		public string FullProjectName {
			get {
				return GetTypedColumnValue<string>("FullProjectName");
			}
			set {
				SetColumnValue("FullProjectName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Activity_ProjectEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Activity_Project_TerrasoftDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Activity_Project_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Activity_ProjectEventsProcess

	/// <exclude/>
	public partial class Activity_ProjectEventsProcess<TEntity> : Terrasoft.Configuration.Activity_CoreContractsEventsProcess<TEntity> where TEntity : Activity_Project_Terrasoft
	{

		public Activity_ProjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Activity_ProjectEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5d2e238c-305a-4610-927c-ede2a53ca517");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess4Project;
		public ProcessFlowElement EventSubProcess4Project {
			get {
				return _eventSubProcess4Project ?? (_eventSubProcess4Project = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4Project",
					SchemaElementUId = new Guid("82cdad80-8535-4329-a833-0697751e3687"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _activitySaved;
		public ProcessFlowElement ActivitySaved {
			get {
				return _activitySaved ?? (_activitySaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivitySaved",
					SchemaElementUId = new Guid("c02c283a-75c5-4338-95f2-3aad5f4db826"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _syncronizeProjectActualStartDate;
		public ProcessScriptTask SyncronizeProjectActualStartDate {
			get {
				return _syncronizeProjectActualStartDate ?? (_syncronizeProjectActualStartDate = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SyncronizeProjectActualStartDate",
					SchemaElementUId = new Guid("a140d34e-d55f-4487-a475-cbc23937c1f8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SyncronizeProjectActualStartDateExecute,
				});
			}
		}

		private ProcessFlowElement _activityDeleted;
		public ProcessFlowElement ActivityDeleted {
			get {
				return _activityDeleted ?? (_activityDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivityDeleted",
					SchemaElementUId = new Guid("fc2b261a-02a4-435a-8513-a2582a1123d4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess4Project.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4Project };
			FlowElements[ActivitySaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivitySaved };
			FlowElements[SyncronizeProjectActualStartDate.SchemaElementUId] = new Collection<ProcessFlowElement> { SyncronizeProjectActualStartDate };
			FlowElements[ActivityDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityDeleted };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess4Project":
						break;
					case "ActivitySaved":
						e.Context.QueueTasks.Enqueue("SyncronizeProjectActualStartDate");
						break;
					case "SyncronizeProjectActualStartDate":
						break;
					case "ActivityDeleted":
						e.Context.QueueTasks.Enqueue("SyncronizeProjectActualStartDate");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ActivitySaved");
			ActivatedEventElements.Add("ActivityDeleted");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess4Project":
					context.QueueTasks.Dequeue();
					break;
				case "ActivitySaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivitySaved";
					result = ActivitySaved.Execute(context);
					break;
				case "SyncronizeProjectActualStartDate":
					context.QueueTasks.Dequeue();
					context.SenderName = "SyncronizeProjectActualStartDate";
					result = SyncronizeProjectActualStartDate.Execute(context, SyncronizeProjectActualStartDateExecute);
					break;
				case "ActivityDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityDeleted";
					result = ActivityDeleted.Execute(context);
					break;
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

		public virtual bool SyncronizeProjectActualStartDateExecute(ProcessExecutingContext context) {
			var projectId = Entity.GetTypedColumnValue<Guid>("ProjectId");
			if (projectId.Equals(Guid.Empty)) {
				return true;
			}
			/*var projectService = new ProjectService.ProjectService();
			projectService.SyncronizeProjectActualStartDate(projectId);
			projectService.SyncronizeProjectActualEndDate(projectId);*/
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ActivitySaved":
							if (ActivatedEventElements.Contains("ActivitySaved")) {
							context.QueueTasks.Enqueue("ActivitySaved");
							ProcessQueue(context);
							return;
						}
						break;
					case "Activity_Project_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("ActivityDeleted")) {
							context.QueueTasks.Enqueue("ActivityDeleted");
						}
						break;
			}
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

	#region Class: Activity_ProjectEventsProcess

	/// <exclude/>
	public class Activity_ProjectEventsProcess : Activity_ProjectEventsProcess<Activity_Project_Terrasoft>
	{

		public Activity_ProjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Activity_ProjectEventsProcess

	public partial class Activity_ProjectEventsProcess<TEntity>
	{

		#region Methods: Public

		public override bool DoCollectEmailParticipants() {
			return Entity.GetTypedColumnValue<Guid>("TypeId") == Terrasoft.Configuration.ActivityConsts.EmailTypeUId
			|| Entity.GetTypedColumnValue<Guid>("ActivityCategoryId") == ExchangeConsts.ActivityMeetingCategoryId;
		}

		public override bool OnActivitySaved(ProcessExecutingContext context) {
			SynchronizeParticipants();
			return base.OnActivitySaved(context);
		}

		#endregion

	}

	#endregion

	#region Class: Activity_Project_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Activity_Project_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Activity_CoreContracts_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Activity_Project_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Activity_Project_TerrasoftEventsProcessSchema(Activity_Project_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Activity_ProjectEventsProcess";
			UId = new Guid("9dcc1a54-1f4d-42d6-937e-c95780780900");
			CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("1e6b597a-7314-4042-bb1d-ab0ec5a9b9fd");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1Project = CreateLaneSet1ProjectLaneSet();
			LaneSets.Add(schemaLaneSet1Project);
			ProcessSchemaLane schemaLane2Project = CreateLane2ProjectLane();
			schemaLaneSet1Project.Lanes.Add(schemaLane2Project);
			ProcessSchemaEventSubProcess eventsubprocess4project = CreateEventSubProcess4ProjectEventSubProcess();
			FlowElements.Add(eventsubprocess4project);
			ProcessSchemaStartMessageEvent activitysaved = CreateActivitySavedStartMessageEvent();
			eventsubprocess4project.FlowElements.Add(activitysaved);
			ProcessSchemaScriptTask syncronizeprojectactualstartdate = CreateSyncronizeProjectActualStartDateScriptTask();
			eventsubprocess4project.FlowElements.Add(syncronizeprojectactualstartdate);
			ProcessSchemaStartMessageEvent activitydeleted = CreateActivityDeletedStartMessageEvent();
			eventsubprocess4project.FlowElements.Add(activitydeleted);
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("f19624cf-6591-455f-a4f5-aad3c76ed6e4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("598a61a2-e86d-4cf8-967f-fdd60abb6c73"),
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc"),
				CreatedInSchemaUId = new Guid("9dcc1a54-1f4d-42d6-937e-c95780780900"),
				CurveCenterPosition = new Point(161, 128),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9dcc1a54-1f4d-42d6-937e-c95780780900"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c02c283a-75c5-4338-95f2-3aad5f4db826"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a140d34e-d55f-4487-a475-cbc23937c1f8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("104083e1-9f3c-438f-b325-79dc9f03bab4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("598a61a2-e86d-4cf8-967f-fdd60abb6c73"),
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc"),
				CreatedInSchemaUId = new Guid("9dcc1a54-1f4d-42d6-937e-c95780780900"),
				CurveCenterPosition = new Point(159, 162),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9dcc1a54-1f4d-42d6-937e-c95780780900"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fc2b261a-02a4-435a-8513-a2582a1123d4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a140d34e-d55f-4487-a475-cbc23937c1f8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1ProjectLaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1Project = new ProcessSchemaLaneSet(this) {
				UId = new Guid("873b3f34-4784-4cd6-989f-707a492eb650"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("598a61a2-e86d-4cf8-967f-fdd60abb6c73"),
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc"),
				CreatedInSchemaUId = new Guid("9dcc1a54-1f4d-42d6-937e-c95780780900"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("9dcc1a54-1f4d-42d6-937e-c95780780900"),
				Name = @"LaneSet1Project",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1560, 445),
				UseBackgroundMode = false
			};
			return schemaLaneSet1Project;
		}

		protected virtual ProcessSchemaLane CreateLane2ProjectLane() {
			ProcessSchemaLane schemaLane2Project = new ProcessSchemaLane(this) {
				UId = new Guid("18638a27-366f-4e4f-9302-0c32e389b07d"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("873b3f34-4784-4cd6-989f-707a492eb650"),
				CreatedInOwnerSchemaUId = new Guid("5d2e238c-305a-4610-927c-ede2a53ca517"),
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc"),
				CreatedInSchemaUId = new Guid("9dcc1a54-1f4d-42d6-937e-c95780780900"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("9dcc1a54-1f4d-42d6-937e-c95780780900"),
				Name = @"Lane2Project",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1531, 445),
				UseBackgroundMode = false
			};
			return schemaLane2Project;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4ProjectEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4Project = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("82cdad80-8535-4329-a833-0697751e3687"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("18638a27-366f-4e4f-9302-0c32e389b07d"),
				CreatedInOwnerSchemaUId = new Guid("598a61a2-e86d-4cf8-967f-fdd60abb6c73"),
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc"),
				CreatedInSchemaUId = new Guid("9dcc1a54-1f4d-42d6-937e-c95780780900"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("9dcc1a54-1f4d-42d6-937e-c95780780900"),
				Name = @"EventSubProcess4Project",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(230, 226),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4Project;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateActivitySavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c02c283a-75c5-4338-95f2-3aad5f4db826"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("82cdad80-8535-4329-a833-0697751e3687"),
				CreatedInOwnerSchemaUId = new Guid("598a61a2-e86d-4cf8-967f-fdd60abb6c73"),
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc"),
				CreatedInSchemaUId = new Guid("9dcc1a54-1f4d-42d6-937e-c95780780900"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ActivitySaved",
				ModifiedInSchemaUId = new Guid("9dcc1a54-1f4d-42d6-937e-c95780780900"),
				Name = @"ActivitySaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(28, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSyncronizeProjectActualStartDateScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a140d34e-d55f-4487-a475-cbc23937c1f8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("82cdad80-8535-4329-a833-0697751e3687"),
				CreatedInOwnerSchemaUId = new Guid("598a61a2-e86d-4cf8-967f-fdd60abb6c73"),
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc"),
				CreatedInSchemaUId = new Guid("9dcc1a54-1f4d-42d6-937e-c95780780900"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9dcc1a54-1f4d-42d6-937e-c95780780900"),
				Name = @"SyncronizeProjectActualStartDate",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(120, 86),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,143,203,10,194,48,16,69,215,6,250,15,161,171,180,139,244,3,124,128,104,40,238,10,21,247,33,25,33,210,166,53,78,42,81,252,119,91,80,107,93,185,156,203,61,156,59,157,116,180,117,205,9,20,238,52,93,82,97,209,96,224,57,224,62,180,160,55,77,229,107,123,144,149,135,69,238,141,94,177,184,120,183,227,100,30,17,115,164,236,195,115,113,246,178,186,176,161,201,69,221,98,72,18,122,143,200,204,1,122,103,41,58,15,61,243,136,72,150,118,163,184,4,215,25,5,189,221,194,149,22,147,144,79,79,54,56,167,24,47,131,85,174,177,230,6,175,238,90,97,63,163,68,233,112,43,17,198,125,255,195,194,234,95,52,205,34,242,253,199,19,4,109,85,61,58,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateActivityDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("fc2b261a-02a4-435a-8513-a2582a1123d4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("82cdad80-8535-4329-a833-0697751e3687"),
				CreatedInOwnerSchemaUId = new Guid("598a61a2-e86d-4cf8-967f-fdd60abb6c73"),
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc"),
				CreatedInSchemaUId = new Guid("9dcc1a54-1f4d-42d6-937e-c95780780900"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ActivityDeleted",
				ModifiedInSchemaUId = new Guid("9dcc1a54-1f4d-42d6-937e-c95780780900"),
				Name = @"ActivityDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 149),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f83cbea2-10c5-4739-96f1-116937efce77"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("19024591-23ea-4b03-9800-93149198129b"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ca241c6a-6bd2-4e33-ae26-164063bfb504"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ed374225-e41d-4643-8234-a4c89997d648"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("382f02c8-59cb-4d9a-a8a5-71c58b6f4a3b"),
				Name = "Terrasoft.Configuration.ProjectService",
				Alias = "",
				CreatedInPackageId = new Guid("9f3f8b4f-d8ea-42e7-81d3-d7cfd66c54fc")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("49a41b26-e223-4e0d-a40a-f81877cefa7a"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6")
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
				UId = new Guid("c8f03a62-627b-4c3c-a7a8-dca7a5be0e70"),
				Name = "System.Text.RegularExpressions",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8141ed71-f702-4246-8bcd-71fef757fdc4"),
				Name = "System.Web",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected override SchemaMethod CreateDoCollectEmailParticipantsMethod() {
			SchemaMethod method = base.CreateDoCollectEmailParticipantsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,141,65,10,194,48,16,69,247,158,162,116,165,155,92,64,43,72,9,165,11,119,213,125,104,166,113,32,157,148,201,68,12,244,240,182,96,117,235,246,241,254,251,12,146,152,10,77,130,146,85,3,210,229,9,108,29,124,26,233,110,124,130,83,147,208,158,247,229,202,91,91,30,138,170,42,58,96,54,49,12,162,234,64,3,186,196,70,48,144,186,244,130,207,165,179,208,40,81,233,209,160,95,119,183,214,238,230,249,143,147,111,192,8,184,192,121,59,212,175,254,97,200,193,39,188,105,87,0,65,114,63,251,248,6,84,176,58,212,207,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateOnActivitySavedMethod() {
			SchemaMethod method = base.CreateOnActivitySavedMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,174,204,75,206,40,202,207,203,172,74,13,72,44,42,201,76,206,44,72,204,43,41,214,208,180,230,229,42,74,45,41,45,202,83,72,74,44,78,213,243,207,115,76,46,201,44,203,44,169,12,78,44,75,77,209,72,206,207,43,73,173,40,209,180,6,0,38,93,6,70,65,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Activity_Project_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9dcc1a54-1f4d-42d6-937e-c95780780900"));
		}

		#endregion

	}

	#endregion

}

