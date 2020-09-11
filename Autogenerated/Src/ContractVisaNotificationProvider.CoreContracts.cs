namespace Terrasoft.Configuration
{
	using Terrasoft.Core.DB;
	using System.Collections.Generic;
	using Terrasoft.Core;
	using System;

	#region Class: ContractVisaNotificationProvider

	public class ContractVisaNotificationProvider : BaseNotificationProvider, INotification
	{

		#region Constants: Private

		private const string GROUP_NAME = "Visa";
		private const string NAME = "Contract";
		private const string ContractVisaSchemaName = "ContractVisa";
		private const string ContractSchemaName = "Contract";

		#endregion

		#region Fields: Private

		private readonly Guid _sysAdminUnitId;

		#endregion

		#region Constructors: Public

		public ContractVisaNotificationProvider(Dictionary<string, object> parameters) : base(parameters) {
			_sysAdminUnitId = (Guid)this.parameters["sysAdminUnitId"];
		}

		public ContractVisaNotificationProvider(UserConnection userConnection)
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
				.Where("SysAdminUnitId").IsEqual(Column.Parameter(_sysAdminUnitId)) as Select;
			return select;
		}

		private QueryCase GetQueryCase() {
			var queryCase = new QueryCase();
			var conditionFirst = new QueryCondition(QueryConditionType.IsNull) {
				LeftExpression = new QueryColumnExpression("SysUserInRole", "SysUserId")
			};
			queryCase.AddWhenItem(conditionFirst, new QueryColumnExpression(ContractVisaSchemaName, "VisaOwnerId"));
			queryCase.ElseExpression = new QueryColumnExpression("SysUserInRole", "SysUserId");
			return queryCase;
		}

		private string GetDate(string datetime) {
			if (String.IsNullOrEmpty(datetime)) {
				return string.Empty;
			}
			var dateMacros = UserConnection.GetLocalizableString("ContractVisaNotificationProvider" ,"DateMacros");
			var result = Convert.ToDateTime(datetime);
			return result.ToString(dateMacros);
		}

		private string GetBody(Dictionary<string, string> dictionaryColumnValues) {
			var body = UserConnection.GetLocalizableString("ContractVisaNotificationProvider", "BodyTemplate");
			var number = dictionaryColumnValues["Title"];
			var dateTime = dictionaryColumnValues["Date"];
			var account = dictionaryColumnValues["Account"];
			var contact = dictionaryColumnValues["Contact"];
			var date = GetDate(dateTime);
			var accountContactString = string.Format("{0}, {1}", account, contact);
			if (String.IsNullOrEmpty(account)) {
				accountContactString = contact;
			}
			if (String.IsNullOrEmpty(contact)) {
				accountContactString = account;
			}
			body = string.Format(body, number, date, accountContactString);
			return body;
		}

		#endregion

		#region Methods: Protected

		protected override Select GetBaseSelect() {
			return new Select(UserConnection)
				.From(ContractVisaSchemaName);
		}

		protected override void AddColumns(Select select) {
			Guid sysImage = GetNotificationImage(ContractVisaSchemaName, null);
			select
				.Column(ContractVisaSchemaName, "Id").As("Id")
				.Column(ContractVisaSchemaName, "Objective").As("Objective")
				.Column(ContractVisaSchemaName, "StatusId").As("StatusId")
				.Column(ContractVisaSchemaName, "IsCanceled").As("IsCanceled")
				.Column(ContractVisaSchemaName, "VisaOwnerId").As("SysAdminUnitId")
				.Column(Column.Parameter(ContractSchemaName)).As("VisaSchemaName")
				.Column(ContractSchemaName, "Number").As("Title")
				.Column(ContractSchemaName, "Id").As("VisaObjectId")
				.Column(ContractSchemaName, "StartDate").As("Date")
				.Column("Account", "Name").As("Account")
				.Column("Contact", "Name").As("Contact")
				.Column(Column.Parameter(ContractSchemaName)).As("SchemaName")
				.Column(Column.Parameter(sysImage)).As("ImageId");
		}

		protected override void JoinTables(Select select) {
			select
				.InnerJoin(ContractSchemaName).On(ContractSchemaName, "Id").IsEqual(ContractVisaSchemaName, "ContractId")
				.LeftOuterJoin("Account").On("Account", "Id").IsEqual(ContractSchemaName, "AccountId")
				.LeftOuterJoin("Contact").On("Contact", "Id").IsEqual(ContractSchemaName, "ContactId");
		}

		protected override void AddConditions(Select select) {
			Guid[] finallyStatuses = NotificationUtilities.GetFinallyVisaStatuses(UserConnection);
			select.Where(ContractVisaSchemaName, "StatusId").Not().In(Column.Parameters(finallyStatuses))
				.And(ContractVisaSchemaName, "IsCanceled").IsEqual(Column.Parameter(false));
		}

		protected override void AddActiveUserFilter(Select select) {
		}

		protected override INotificationInfo GetRecordNotificationInfo(Dictionary<string, string> dictionaryColumnValues) {
			var title = UserConnection.GetLocalizableString("ContractVisaNotificationProvider", "TitleTemplate");
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

		public override string GetRecordResult(Dictionary<string, string> dictionaryColumnValues) {
			var body = GetBody(dictionaryColumnValues);
			var title = UserConnection.GetLocalizableString("ContractVisaNotificationProvider", "TitleTemplate");
			var notificationId = dictionaryColumnValues["Id"];
			var entityId = dictionaryColumnValues["VisaObjectId"];
			var schemaName = dictionaryColumnValues["SchemaName"];
			var imageId = dictionaryColumnValues["ImageId"];
			var popup = new PopupData() {
				Title = title,
				Body = body,
				ImageId = imageId,
				EntityId = entityId,
				EntitySchemaName = schemaName
			};
			var serializePopup = popup.Serialize();
			return string.Format(template, notificationId, serializePopup);
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

		public override Select GetEntitiesSelect() {
			Select sysAdminUnitInRoleSelect = GetSysAdminUnitInRoleSelect();
			var contractEntitySchema = UserConnection.EntitySchemaManager.FindItemByName(ContractSchemaName);
			string contractCaption = contractEntitySchema.Caption;
			Guid sysImage = GetNotificationImage(ContractVisaSchemaName, null);
			Guid[] finallyStatuses = NotificationUtilities.GetFinallyVisaStatuses(UserConnection);
			QueryCase queryCase = GetQueryCase();
			var entitiesSelect = new Select(UserConnection)
				.Column(ContractVisaSchemaName, "Id")
				.Column(ContractVisaSchemaName, "CreatedOn")
				.Column(ContractVisaSchemaName, "CreatedById")
				.Column(ContractVisaSchemaName, "ModifiedOn")
				.Column(ContractVisaSchemaName, "ModifiedById")
				.Column(ContractVisaSchemaName, "ProcessListeners")
				.Column(ContractVisaSchemaName, "Objective")
				.Column(queryCase).As("VisaOwnerId")
				.Column(ContractVisaSchemaName, "IsAllowedToDelegate")
				.Column(ContractVisaSchemaName, "DelegatedFromId")
				.Column(ContractVisaSchemaName, "StatusId")
				.Column(ContractVisaSchemaName, "SetById")
				.Column(ContractVisaSchemaName, "SetDate")
				.Column(ContractVisaSchemaName, "IsCanceled")
				.Column(ContractVisaSchemaName, "Comment")
				.Column(Column.Parameter(ContractSchemaName)).As("VisaSchemaName")
				.Column(ContractSchemaName, "Number").As("Title")
				.Column(ContractSchemaName, "Id").As("VisaObjectId")
				.Column(ContractSchemaName, "StartDate").As("Date")
				.Column("Account", "Name").As("Account")
				.Column("Contact", "Name").As("Contact")
				.Column(ContractSchemaName, "TypeId").As("VisaSchemaTypeId")
				.Column("ContractType", "Name").As("VisaTypeName")
				.Column(Column.Parameter(contractCaption)).As("VisaSchemaCaption")
				.Column(Column.Parameter(ContractSchemaName)).As("SchemaName")
				.Column(Column.Parameter(sysImage)).As("ImageId")
				.Distinct()
				.From(ContractVisaSchemaName)
				.InnerJoin(ContractSchemaName).On(ContractSchemaName, "Id").IsEqual(ContractVisaSchemaName, "ContractId")
				.InnerJoin(sysAdminUnitInRoleSelect).As("SysAdminUnitRole")
					.On(ContractVisaSchemaName, "VisaOwnerId").IsEqual("SysAdminUnitRole", "SysAdminUnitRoleId")
				.LeftOuterJoin("SysUserInRole")
					.On("SysUserInRole", "SysRoleId").IsEqual("SysAdminUnitRole", "SysAdminUnitId")
				.InnerJoin("ContractType").On("ContractType", "Id").IsEqual(ContractSchemaName, "TypeId")
				.LeftOuterJoin("Account").On("Account", "Id").IsEqual(ContractSchemaName, "AccountId")
				.LeftOuterJoin("Contact").On("Contact", "Id").IsEqual(ContractSchemaName, "ContactId")
				.Where(ContractVisaSchemaName, "VisaOwnerId").In(
					new Select(UserConnection).Column("SysAdminUnitRoleId").From("SysAdminUnitInRole")
						.Where("SysAdminUnitId").IsEqual(Column.Parameter(_sysAdminUnitId)))
				.And(ContractVisaSchemaName, "StatusId").Not().In(Column.Parameters(finallyStatuses))
				.And(ContractVisaSchemaName, "IsCanceled").IsEqual(Column.Parameter(false)) as Select;
			return entitiesSelect;
		}

		#endregion

	}

	#endregion
}

