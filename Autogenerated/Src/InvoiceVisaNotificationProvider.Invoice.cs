namespace Terrasoft.Configuration {
	using System;
	using System.Collections.Generic;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;

	#region Class: InvoiceVisaNotificationProvider

	public class InvoiceVisaNotificationProvider : BaseNotificationProvider, INotification 
	{

		#region Constants: Private

		private const string GROUP_NAME = "Visa";
		private const string NAME = "Invoice";
		private const string InvoiceVisaSchemaName = "InvoiceVisa";
		private const string InvoiceSchemaName = "Invoice";

		#endregion

		#region Fields: Private

		private readonly Guid _sysAdminUnit;

		#endregion

		#region Constructors: Public

		public InvoiceVisaNotificationProvider(Dictionary<string, object> parameters)
			: base(parameters) {
			_sysAdminUnit = (Guid)this.parameters["sysAdminUnitId"];
		}

		public InvoiceVisaNotificationProvider(UserConnection userConnection)
			: base(userConnection) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Group name.
		/// </summary>
		public string Group {
			get {
				return GROUP_NAME;
			}
		}

		/// <summary>
		/// Provider name.
		/// </summary>
		public string Name {
			get {
				return NAME;
			}
		}

		#endregion

		#region Methods: Private

		private Select GetSysAdminUnitInRoleSelect() {
			var select = new Select(UserConnection)
				.Column("SysAdminUnitId")
				.Column("SysAdminUnitRoleId")
				.From("SysAdminUnitInRole")
				.Where("SysAdminUnitId").IsEqual(Column.Parameter(_sysAdminUnit)) as Select;
			return select;
		}

		private QueryCase GetQueryCase() {
			var queryCase = new QueryCase();
			var conditionFirst = new QueryCondition(QueryConditionType.IsNull) {
				LeftExpression = new QueryColumnExpression("SysUserInRole", "SysUserId")
			};
			queryCase.AddWhenItem(conditionFirst, new QueryColumnExpression(InvoiceVisaSchemaName, "VisaOwnerId"));
			queryCase.ElseExpression = new QueryColumnExpression("SysUserInRole", "SysUserId");
			return queryCase;
		}

		private string GetDate(string datetime) {
			var dateMacros = UserConnection.GetLocalizableString("InvoiceVisaNotificationProvider", "DateMacros");
			var result = Convert.ToDateTime(datetime);
			return result.ToString(dateMacros);
		}

		private string GetBody(Dictionary<string, string> dictionaryColumnValues) {
			var bodyTemplate = UserConnection.GetLocalizableString("InvoiceVisaNotificationProvider", "BodyTemplate");
			var number = dictionaryColumnValues["Title"];
			var dateTime = dictionaryColumnValues["Date"];
			var account = dictionaryColumnValues["Account"];
			var contact = dictionaryColumnValues["Contact"];
			string date = GetDate(dateTime);
			var accountContactString = string.Format("{0}, {1}", account, contact);
			if (String.IsNullOrEmpty(account)) {
				accountContactString = contact;
			}
			if (String.IsNullOrEmpty(contact)) {
				accountContactString = account;
			}
			var body = string.Format(bodyTemplate, number, date, accountContactString);
			return body;
		}

		#endregion

		#region Methods: Protected

		protected override Select GetBaseSelect() {
			return new Select(UserConnection)
				.From(InvoiceVisaSchemaName);
		}

		protected override void AddColumns(Select select) {
			Guid sysImage = GetNotificationImage(InvoiceVisaSchemaName, RemindingConsts.NotificationTypeRemindingId);
			select
				.Column(InvoiceVisaSchemaName, "Id").As("Id")
				.Column(InvoiceVisaSchemaName, "Objective").As("Objective")
				.Column(InvoiceVisaSchemaName, "StatusId").As("StatusId")
				.Column(InvoiceVisaSchemaName, "IsCanceled").As("IsCanceled")
				.Column(InvoiceVisaSchemaName, "VisaOwnerId").As("SysAdminUnitId")
				.Column(Column.Parameter(InvoiceSchemaName)).As("VisaSchemaName")
				.Column(InvoiceSchemaName, "Number").As("Title")
				.Column(InvoiceSchemaName, "Id").As("VisaObjectId")
				.Column(InvoiceSchemaName, "StartDate").As("Date")
				.Column("Account", "Name").As("Account")
				.Column("Contact", "Name").As("Contact")
				.Column(Column.Parameter(InvoiceSchemaName)).As("SchemaName")
				.Column(Column.Parameter(sysImage)).As("ImageId");
		}

		protected override void JoinTables(Select select) {
			select
				.InnerJoin(InvoiceSchemaName).On(InvoiceSchemaName, "Id").IsEqual(InvoiceVisaSchemaName, "InvoiceId")
				.LeftOuterJoin("Account").On("Account", "Id").IsEqual(InvoiceSchemaName, "AccountId")
				.LeftOuterJoin("Contact").On("Contact", "Id").IsEqual(InvoiceSchemaName, "ContactId");
		}

		protected override void AddConditions(Select select) {
			Guid[] finallyStatuses = NotificationUtilities.GetFinallyVisaStatuses(UserConnection);
			select.Where(InvoiceVisaSchemaName, "StatusId").Not().In(Column.Parameters(finallyStatuses))
				.And(InvoiceVisaSchemaName, "IsCanceled").IsEqual(Column.Parameter(false));
		}

		protected override void AddActiveUserFilter(Select select) {
		}

		protected override INotificationInfo GetRecordNotificationInfo(Dictionary<string, string> dictionaryColumnValues) {
			var title = UserConnection.GetLocalizableString("InvoiceVisaNotificationProvider", "TitleTemplate");
			Guid imageId;
			Guid.TryParse(dictionaryColumnValues["ImageId"], out imageId);
			return new NotificationInfo {
				Title = title,
				Body = GetBody(dictionaryColumnValues),
				ImageId = imageId,
				EntityId = new Guid(dictionaryColumnValues["VisaObjectId"]),
				EntitySchemaName = dictionaryColumnValues["VisaSchemaName"],
				MessageId = new Guid(dictionaryColumnValues["Id"]),
				SysAdminUnit = new Guid(dictionaryColumnValues["SysAdminUnitId"]),
				GroupName = Group
			};
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Returns notification.
		/// </summary>
		/// <returns>Notification.</returns>
		public IEnumerable<INotificationInfo> GetNotifications() {
			return GetNotificationsInfos();
		}

		public override void SetColumns(List<string> columns) {
			columns.Add("Id");
			columns.Add("Title");
			columns.Add("Date");
			columns.Add("Account");
			columns.Add("Contact");
			columns.Add("VisaObjectId");
			columns.Add("SchemaName");
			columns.Add("ImageId");
		}

		public override string GetRecordResult(Dictionary<string, string> dictionaryColumnValues) {
			var bodyTemplate = UserConnection.GetLocalizableString("InvoiceVisaNotificationProvider", "BodyTemplate");
			var titleTemplate = UserConnection.GetLocalizableString("InvoiceVisaNotificationProvider", "TitleTemplate");
			var notificationId = dictionaryColumnValues["Id"];
			var number = dictionaryColumnValues["Title"];
			var dateTime = dictionaryColumnValues["Date"];
			var account = dictionaryColumnValues["Account"];
			var contact = dictionaryColumnValues["Contact"];
			var entityId = dictionaryColumnValues["VisaObjectId"];
			var schemaName = dictionaryColumnValues["SchemaName"];
			var imageId = dictionaryColumnValues["ImageId"];
			var date = GetDate(dateTime);
			var accountContactString = string.Format("{0}, {1}", account, contact);
			if (String.IsNullOrEmpty(account)) {
				accountContactString = contact;
			}
			if (String.IsNullOrEmpty(contact)) {
				accountContactString = account;
			}
			var body = string.Format(bodyTemplate, number, date, accountContactString);
			var popup = new PopupData() {
				Title = titleTemplate,
				Body = body,
				ImageId = imageId,
				EntityId = entityId,
				EntitySchemaName = schemaName
			};
			var serializePopup = popup.Serialize();
			return string.Format(template, notificationId, serializePopup);
		}

		public override Select GetEntitiesSelect() {
			Select sysAdminUnitInRoleSelect = GetSysAdminUnitInRoleSelect();
			ISchemaManagerItem<EntitySchema> invoiceEntitySchema =
				UserConnection.EntitySchemaManager.FindItemByName(InvoiceSchemaName);
			Guid sysImage = GetNotificationImage(InvoiceVisaSchemaName, RemindingConsts.NotificationTypeRemindingId);
			Guid[] finallyStatuses = NotificationUtilities.GetFinallyVisaStatuses(UserConnection);
			string invoiceCaption = invoiceEntitySchema.Caption;
			QueryCase queryCase = GetQueryCase();
			var entitiesSelect = new Select(UserConnection)
				.Column(InvoiceVisaSchemaName, "Id")
				.Column(InvoiceVisaSchemaName, "CreatedOn")
				.Column(InvoiceVisaSchemaName, "CreatedById")
				.Column(InvoiceVisaSchemaName, "ModifiedOn")
				.Column(InvoiceVisaSchemaName, "ModifiedById")
				.Column(InvoiceVisaSchemaName, "ProcessListeners")
				.Column(InvoiceVisaSchemaName, "Objective")
				.Column(queryCase).As("VisaOwnerId")
				.Column(InvoiceVisaSchemaName, "IsAllowedToDelegate")
				.Column(InvoiceVisaSchemaName, "DelegatedFromId")
				.Column(InvoiceVisaSchemaName, "StatusId")
				.Column(InvoiceVisaSchemaName, "SetById")
				.Column(InvoiceVisaSchemaName, "SetDate")
				.Column(InvoiceVisaSchemaName, "IsCanceled")
				.Column(InvoiceVisaSchemaName, "Comment")
				.Column(Column.Parameter(InvoiceSchemaName)).As("VisaSchemaName")
				.Column(InvoiceSchemaName, "Number").As("Title")
				.Column(InvoiceSchemaName, "Id").As("VisaObjectId")
				.Column(InvoiceSchemaName, "StartDate").As("Date")
				.Column("Account", "Name").As("Account")
				.Column("Contact", "Name").As("Contact")
				.Column(Column.Parameter(Guid.Empty)).As("VisaSchemaTypeId")
				.Column(Column.Parameter(string.Empty)).As("VisaTypeName")
				.Column(Column.Parameter(invoiceCaption)).As("VisaSchemaCaption")
				.Column(Column.Parameter(InvoiceSchemaName)).As("SchemaName")
				.Column(Column.Parameter(sysImage)).As("ImageId")
				.Distinct()
				.From(InvoiceVisaSchemaName)
				.InnerJoin(InvoiceSchemaName).On(InvoiceSchemaName, "Id").IsEqual(InvoiceVisaSchemaName, "InvoiceId")
				.InnerJoin(sysAdminUnitInRoleSelect).As("SysAdminUnitRole")
					.On(InvoiceVisaSchemaName, "VisaOwnerId").IsEqual("SysAdminUnitRole", "SysAdminUnitRoleId")
				.LeftOuterJoin("SysUserInRole")
					.On("SysUserInRole", "SysRoleId").IsEqual("SysAdminUnitRole", "SysAdminUnitId")
				.LeftOuterJoin("Account").On("Account", "Id").IsEqual(InvoiceSchemaName, "AccountId")
				.LeftOuterJoin("Contact").On("Contact", "Id").IsEqual(InvoiceSchemaName, "ContactId")
				.Where(InvoiceVisaSchemaName, "VisaOwnerId").In(
					new Select(UserConnection).Column("SysAdminUnitRoleId").From("SysAdminUnitInRole")
						.Where("SysAdminUnitId").IsEqual(Column.Parameter(_sysAdminUnit)))
				.And(InvoiceVisaSchemaName, "StatusId").Not().In(Column.Parameters(finallyStatuses))
				.And(InvoiceVisaSchemaName, "IsCanceled").IsEqual(Column.Parameter(false)) as Select;
			return entitiesSelect;
		}

		#endregion

	}

	#endregion
}
