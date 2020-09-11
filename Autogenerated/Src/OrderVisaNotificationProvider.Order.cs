namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;

	#region Class: OrderVisaNotificationProvider

	public class OrderVisaNotificationProvider : BaseNotificationProvider, INotification
	{

		#region Constants: Private

		private const string GROUP_NAME = "Visa";
		private const string NAME = "Order";
		private const string OrderVisaSchemaName = "OrderVisa";
		private const string OrderSchemaName = "Order";

		#endregion

		#region Fields: Private

		private readonly Guid _sysAdminUnit;

		#endregion

		#region Constructors: Public

		public OrderVisaNotificationProvider(Dictionary<string, object> parameters)
			: base(parameters) {
			_sysAdminUnit = (Guid)this.parameters["sysAdminUnitId"];
		}

		public OrderVisaNotificationProvider(UserConnection userConnection)
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
			queryCase.AddWhenItem(conditionFirst, new QueryColumnExpression(OrderVisaSchemaName, "VisaOwnerId"));
			queryCase.ElseExpression = new QueryColumnExpression("SysUserInRole", "SysUserId");
			return queryCase;
		}

		private string GetDate(string datetime) {
			var dateMacros = UserConnection.GetLocalizableString("OrderVisaNotificationProvider", "DateMacros");
			var result = Convert.ToDateTime(datetime);
			return result.ToString(dateMacros);
		}

		private string GetBody(Dictionary<string, string> dictionaryColumnValues) {
			var bodyTemplate = UserConnection.GetLocalizableString("OrderVisaNotificationProvider", "BodyTemplate");
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
				.From(OrderVisaSchemaName);
		}

		protected override void AddColumns(Select select) {
			Guid sysImage = GetNotificationImage(OrderVisaSchemaName, null);
			select
				.Column(OrderVisaSchemaName, "Id").As("Id")
				.Column(OrderVisaSchemaName, "Objective").As("Objective")
				.Column(OrderVisaSchemaName, "StatusId").As("StatusId")
				.Column(OrderVisaSchemaName, "IsCanceled").As("IsCanceled")
				.Column(OrderVisaSchemaName, "VisaOwnerId").As("SysAdminUnitId")
				.Column(Column.Parameter(OrderSchemaName)).As("VisaSchemaName")
				.Column(OrderSchemaName, "Number").As("Title")
				.Column(OrderSchemaName, "Id").As("VisaObjectId")
				.Column(OrderSchemaName, "Date").As("Date")
				.Column("Account", "Name").As("Account")
				.Column("Contact", "Name").As("Contact")
				.Column(Column.Parameter(OrderSchemaName)).As("SchemaName")
				.Column(Column.Parameter(sysImage)).As("ImageId");
		}

		protected override void JoinTables(Select select) {
			select
				.InnerJoin(OrderSchemaName).On(OrderSchemaName, "Id").IsEqual(OrderVisaSchemaName, "OrderId")
				.LeftOuterJoin("Account").On("Account", "Id").IsEqual(OrderSchemaName, "AccountId")
				.LeftOuterJoin("Contact").On("Contact", "Id").IsEqual(OrderSchemaName, "ContactId");
		}

		protected override void AddConditions(Select select) {
			Guid[] finallyStatuses = NotificationUtilities.GetFinallyVisaStatuses(UserConnection);
			select.Where(OrderVisaSchemaName, "StatusId").Not().In(Column.Parameters(finallyStatuses))
				.And(OrderVisaSchemaName, "IsCanceled").IsEqual(Column.Parameter(false));
		}

		protected override void AddActiveUserFilter(Select select) {
		}

		protected override INotificationInfo GetRecordNotificationInfo(Dictionary<string, string> dictionaryColumnValues) {
			var title = UserConnection.GetLocalizableString("OrderVisaNotificationProvider", "TitleTemplate");
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
			var bodyTemplate = UserConnection.GetLocalizableString("OrderVisaNotificationProvider", "BodyTemplate");
			var titleTemplate = UserConnection.GetLocalizableString("OrderVisaNotificationProvider", "TitleTemplate");
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
			ISchemaManagerItem<EntitySchema> orderEntitySchema = UserConnection.EntitySchemaManager.FindItemByName(OrderSchemaName);
			string orderCaption = orderEntitySchema.Caption;
			Guid sysImage = GetNotificationImage(OrderVisaSchemaName, null);
			Guid[] finallyStatuses = NotificationUtilities.GetFinallyVisaStatuses(UserConnection);
			QueryCase queryCase = GetQueryCase();
			var entitiesSelect = new Select(UserConnection)
				.Column(OrderVisaSchemaName, "Id")
				.Column(OrderVisaSchemaName, "CreatedOn")
				.Column(OrderVisaSchemaName, "CreatedById")
				.Column(OrderVisaSchemaName, "ModifiedOn")
				.Column(OrderVisaSchemaName, "ModifiedById")
				.Column(OrderVisaSchemaName, "ProcessListeners")
				.Column(OrderVisaSchemaName, "Objective")
				.Column(queryCase).As("VisaOwnerId")
				.Column(OrderVisaSchemaName, "IsAllowedToDelegate")
				.Column(OrderVisaSchemaName, "DelegatedFromId")
				.Column(OrderVisaSchemaName, "StatusId")
				.Column(OrderVisaSchemaName, "SetById")
				.Column(OrderVisaSchemaName, "SetDate")
				.Column(OrderVisaSchemaName, "IsCanceled")
				.Column(OrderVisaSchemaName, "Comment")
				.Column(Column.Parameter(OrderSchemaName)).As("VisaSchemaName")
				.Column(OrderSchemaName, "Number").As("Title")
				.Column(OrderSchemaName, "Id").As("VisaObjectId")
				.Column(OrderSchemaName, "Date").As("Date")
				.Column("Account", "Name").As("Account")
				.Column("Contact", "Name").As("Contact")
				.Column(Column.Parameter(Guid.Empty)).As("VisaSchemaTypeId")
				.Column(Column.Parameter(string.Empty)).As("VisaTypeName")
				.Column(Column.Parameter(orderCaption)).As("VisaSchemaCaption")
				.Column(Column.Parameter(OrderSchemaName)).As("SchemaName")
				.Column(Column.Parameter(sysImage)).As("ImageId")
				.Distinct()
				.From(OrderVisaSchemaName)
					.InnerJoin(OrderSchemaName).On(OrderSchemaName, "Id").IsEqual(OrderVisaSchemaName, "OrderId")
					.InnerJoin(sysAdminUnitInRoleSelect).As("SysAdminUnitRole")
							.On(OrderVisaSchemaName, "VisaOwnerId").IsEqual("SysAdminUnitRole", "SysAdminUnitRoleId")
					.LeftOuterJoin("SysUserInRole")
						.On("SysUserInRole", "SysRoleId").IsEqual("SysAdminUnitRole", "SysAdminUnitId")
					.LeftOuterJoin("Account").On("Account", "Id").IsEqual(OrderSchemaName, "AccountId")
					.LeftOuterJoin("Contact").On("Contact", "Id").IsEqual(OrderSchemaName, "ContactId")
				.Where(OrderVisaSchemaName, "VisaOwnerId").In(
					new Select(UserConnection).Column("SysAdminUnitRoleId").From("SysAdminUnitInRole")
						.Where("SysAdminUnitId").IsEqual(Column.Parameter(_sysAdminUnit)))
					.And(OrderVisaSchemaName, "StatusId").Not().In(Column.Parameters(finallyStatuses))
					.And(OrderVisaSchemaName, "IsCanceled").IsEqual(Column.Parameter(false)) as Select;
			return entitiesSelect;
		}

		#endregion

	}

	#endregion
}
