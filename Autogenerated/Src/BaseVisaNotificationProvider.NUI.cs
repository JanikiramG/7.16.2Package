namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;

	#region Class: BaseVisaNotificationProvider

	public class BaseVisaNotificationProvider : BaseNotificationProvider
	{

		#region Constants: Private

		private const string ResourceManagerName = "BaseVisaNotificationProvider";

		#endregion

		#region Fields: Private

		private readonly Guid _vizaPopupIconPngId = new Guid("c9cd223e-c552-4c48-94c0-01afc67b3997");
		private readonly Guid _sysAdminUnit;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="BaseVisaNotificationProvider"/> class with parameters.
		/// </summary>
		/// <param name="parameters">Parameters dictionary.</param>
		public BaseVisaNotificationProvider(Dictionary<string, object> parameters)
			: base(parameters) {
			_sysAdminUnit = (Guid)this.parameters["sysAdminUnitId"];
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BaseVisaNotificationProvider"/> class with parameters.
		/// </summary>
		/// <param name="userConnection">UserConnection.</param>
		public BaseVisaNotificationProvider(UserConnection userConnection)
			: base(userConnection) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Group name.
		/// </summary>
		public string Group {
			get {
				return "Visa";
			}
		}

		/// <summary>
		/// Entity schema name.
		/// </summary>
		public virtual string Name {
			get;
			set;
		}

		/// <summary>
		/// Entity schema caption.
		/// </summary>
		public virtual string Caption {
			get;
			set;
		}

		/// <summary>
		/// Visa entity schema name.
		/// </summary>
		public virtual string Visa {
			get;
			set;
		}

		/// <summary>
		/// Visa entity value column name.
		/// </summary>
		public virtual string VisaMasterColumn {
			get;
			set;
		}

		/// <summary>
		/// Visa title column name.
		/// </summary>
		public virtual string TitleColumn {
			get;
			set;
		}

		/// <summary>
		/// Visa image identifier.
		/// </summary>
		public virtual Guid ImageId {
			get;
			set;
		}

		/// <summary>
		/// Entity schema manager.
		/// </summary>
		public EntitySchemaManager EntitySchemaManager {
			get {
				return UserConnection.EntitySchemaManager;
			}
		}

		#endregion

		#region Methods: Private

		private Select GetSysAdminUnitInRoleSelect() {
			var select =
				new Select(UserConnection)
					.Column("SysAdminUnitId")
					.Column("SysAdminUnitRoleId")
				.From("SysAdminUnitInRole")
				.Where("SysAdminUnitId").IsEqual(Column.Parameter(_sysAdminUnit)) as Select;
			return select;
		}

		private QueryCase GetVisaOwnerQueryCase() {
			var queryCase = new QueryCase();
			var conditionFirst = new QueryCondition(QueryConditionType.IsNull) {
				LeftExpression = new QueryColumnExpression("SysUserInRole", "SysUserId")
			};
			queryCase.AddWhenItem(conditionFirst, new QueryColumnExpression(Visa, "VisaOwnerId"));
			queryCase.ElseExpression = new QueryColumnExpression("SysUserInRole", "SysUserId");
			return queryCase;
		}

		private string FormatDate(string datetime) {
			DateTime result;
			string dateMacros = UserConnection.GetLocalizableString(ResourceManagerName, "DateMacros");
			if (DateTime.TryParse(datetime, out result)) {
				return result.ToString(dateMacros);
			}
			return datetime ?? string.Empty;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Appending name of columns for creating .
		/// </summary>
		/// <param name="columns">Columns.</param>
		public override void SetColumns(List<string> columns) {
			columns.Add("Id");
			columns.Add("Title");
			columns.Add("Date");
			columns.Add("VisaObjectId");
			columns.Add("SchemaName");
			columns.Add("VisaSchemaName");
			columns.Add("VisaSchemaCaption");
			columns.Add("ImageId");
		}

		/// <summary>
		/// Returns the record visa notification text.
		/// </summary>
		/// <param name="columnValues">Column values.</param>
		public override string GetRecordResult(Dictionary<string, string> columnValues) {
			string bodyTemplate = UserConnection.GetLocalizableString(ResourceManagerName, "BodyTemplate");
			string titleTemplate = UserConnection.GetLocalizableString(ResourceManagerName, "TitleTemplate");
			string notificationId = columnValues["Id"];
			string objective = columnValues["Title"];
			string dateTime = columnValues["Date"];
			string entityId = columnValues["VisaObjectId"];
			string schemaName = columnValues["SchemaName"];
			string schemaCaption = columnValues["VisaSchemaCaption"];
			string body = string.Format(bodyTemplate, schemaCaption, objective, FormatDate(dateTime));
			var popup = new PopupData() {
				Title = titleTemplate,
				Body = body,
				ImageId = _vizaPopupIconPngId.ToString(),
				EntityId = entityId,
				EntitySchemaName = schemaName
			};
			string serializePopup = popup.Serialize();
			return string.Format(template, notificationId, serializePopup);
		}

		/// <summary>
		/// Returns <see cref="Select"/> of entity./>
		/// </summary>
		/// <returns>A <see cref="Select"/> instance.</returns>
		public override Select GetEntitiesSelect() {
			Select sysAdminUnitInRoleSelect = GetSysAdminUnitInRoleSelect();
			Guid[] finallyStatuses = NotificationUtilities.GetFinallyVisaStatuses(UserConnection);
			QueryCase queryCase = GetVisaOwnerQueryCase();
			var entitiesSelect = new Select(UserConnection)
				.Distinct()
				.Column(Visa, "Id")
				.Column(Visa, "CreatedOn")
				.Column(Visa, "CreatedById")
				.Column(Visa, "ModifiedOn")
				.Column(Visa, "ModifiedById")
				.Column(Visa, "ProcessListeners")
				.Column(Visa, "Objective").As("Objective")
				.Column(queryCase).As("VisaOwnerId")
				.Column(Visa, "IsAllowedToDelegate")
				.Column(Visa, "DelegatedFromId")
				.Column(Visa, "StatusId")
				.Column(Visa, "SetById")
				.Column(Visa, "SetDate").As("SetDate")
				.Column(Visa, "IsCanceled")
				.Column(Visa, "Comment")
				.Column(Column.Parameter(Visa)).As("VisaSchemaName")
				.Column(Name, TitleColumn).As("Title")
				.Column(Name, "Id").As("VisaObjectId")
				.Column(Visa, "CreatedOn").As("Date")
				.Column(Column.Parameter(string.Empty)).As("Account")
				.Column(Column.Parameter(string.Empty)).As("Contact")
				.Column(Column.Parameter(Guid.Empty)).As("VisaSchemaTypeId")
				.Column(Column.Parameter(string.Empty)).As("VisaTypeName")
				.Column(Column.Parameter(Caption)).As("VisaSchemaCaption")
				.Column(Column.Parameter(Name)).As("SchemaName")
				.Column(Column.Parameter(ImageId)).As("ImageId")
				.From(Visa)
					.InnerJoin(Name).On(Name, "Id").IsEqual(Visa, VisaMasterColumn)
					.InnerJoin(sysAdminUnitInRoleSelect).As("SysAdminUnitRole")
						.On(Visa, "VisaOwnerId").IsEqual("SysAdminUnitRole", "SysAdminUnitRoleId")
					.LeftOuterJoin("SysUserInRole")
						.On("SysUserInRole", "SysRoleId").IsEqual("SysAdminUnitRole", "SysAdminUnitId")
				.Where(Visa, "VisaOwnerId").In(
					new Select(UserConnection).Column("SysAdminUnitRoleId").From("SysAdminUnitInRole")
						.Where("SysAdminUnitId").IsEqual(Column.Parameter(_sysAdminUnit)))
					.And().OpenBlock(Visa, "StatusId").Not().In(Column.Parameters(finallyStatuses))
						.Or(Visa, "StatusId").IsNull()
						.CloseBlock()
					.And(Visa, "IsCanceled").IsEqual(Column.Parameter(false)) as Select;
			return entitiesSelect;
		}

		#endregion

	}

	#endregion
}
