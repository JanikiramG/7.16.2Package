namespace Terrasoft.Configuration.ML
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Factories;

	#region Class: MLModelEventsNotifier

	/// <summary>
	/// Notifies users about ML model events.
	/// </summary>
	public class MLModelEventsNotifier
	{

		#region Constants: Private

		private const string NotificationSysAdminUnitSettingsName = "MlModelEventsNotificationGroup";

		#endregion

		#region Fields: Private

		private readonly UserConnection _userConnection;
		private readonly Guid _contactSchemaUId = new Guid("16BE3651-8FE2-4159-8DD0-A803D4683DD3");

		#endregion

		#region Properties: Private

		private Guid NotificationSysAdminUnitGroup {
			get {
				return Core.Configuration.SysSettings.GetValue(_userConnection,
					NotificationSysAdminUnitSettingsName, Guid.Empty);
			}
		}

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="MLModelEventsNotifier"/> class.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		public MLModelEventsNotifier(UserConnection userConnection) {
			userConnection.CheckArgumentNull("userConnection");
			_userConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		private IEnumerable<Guid> GetTargetContacts() {
			var result = new List<Guid>();
			if (NotificationSysAdminUnitGroup == Guid.Empty) {
				return result;
			}
			var select = (Select)new Select(_userConnection)
				.Column("SysAdminUnit", "ContactId")
				.From("SysUserInRole")
				.Join(JoinType.Inner, "SysAdminUnit").On("SysAdminUnit", "Id").IsEqual("SysUserInRole", "SysUserId")
				.Where("SysUserInRole", "SysRoleId").IsEqual(Column.Parameter(NotificationSysAdminUnitGroup));
			using (DBExecutor dbExecutor = _userConnection.EnsureDBConnection()) {
				using (IDataReader dataReader = select.ExecuteReader(dbExecutor)) {
					while(dataReader.Read()) {
						Guid contactId = dataReader.GetColumnValue<Guid>("ContactId");
						result.Add(contactId);
					}
				}
			}
			return result;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Notifies the model owners.
		/// </summary>
		/// <param name="message">The message for notification.</param>
		public virtual void NotifyModelEventRecipients(string message) {
			if (!_userConnection.GetIsFeatureEnabled("MLNotifications")) {
				return;
			}
			var remindingUtilities = ClassFactory.Get<RemindingUtilities>();
			foreach (Guid contactId in GetTargetContacts()) {
				var config = new RemindingConfig(_contactSchemaUId) {
					AuthorId = _userConnection.CurrentUser.ContactId,
					ContactId = contactId,
					SubjectId = contactId,
					Description = message
				};
				remindingUtilities.CreateReminding(_userConnection, config);
			}
		}

		#endregion

	}

	#endregion

}

