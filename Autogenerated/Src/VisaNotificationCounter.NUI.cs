namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Core.Factories;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;

	#region Class: VisaNotificationCounter

	/// <summary>
	/// Provides a method to get the number of visa notification.
	/// </summary>
	public class VisaNotificationCounter : INotificationCounter
	{
		#region Fields: Private

		private readonly UserConnection _userConnection;
		private IEntityRepository<SysModuleVisaData> _sysModuleVisaRepository;

		#endregion

		#region Constructors: Public

		public VisaNotificationCounter(UserConnection userConnection) {
			userConnection.CheckArgumentNull(nameof(userConnection));
			_userConnection = userConnection;
		}

		#endregion

		#region Property: Public

		public IEntityRepository<SysModuleVisaData> SysModuleVisaRepository {
			get => _sysModuleVisaRepository ?? (_sysModuleVisaRepository = ClassFactory
				       .Get<CachedSysModuleVisaRepository>(
					       new ConstructorArgument("userConnection", _userConnection)));
			set {
				if (_sysModuleVisaRepository != null) {
					throw new InvalidOperationException();
				}
				_sysModuleVisaRepository = value ?? throw new ArgumentNullException("SysModuleVisaRepository");
			}
		}

		#endregion

		#region Methods: Private

		private IEnumerable<string> GetVisaSchemasNames() {
			IEnumerable<SysModuleVisaData> sysModuleVisaDatas = SysModuleVisaRepository.GetAll();
			return sysModuleVisaDatas.Select(sysModuleVisaData => sysModuleVisaData.VisaSchemaName);
		}

		private int GetVisaCount(string sysModuleVisaName, Guid contactId) {
			Guid[] finallyStatuses = NotificationUtilities.GetFinallyVisaStatuses(_userConnection);
			var visaSelect = (Select) new Select(_userConnection)
				.Column(Func.Count(Column.Asterisk())).As("Count")
				.From(sysModuleVisaName)
				.InnerJoin("SysAdminUnitInRole")
					.On("SysAdminUnitInRole", "SysAdminUnitRoleId").IsEqual(sysModuleVisaName, "VisaOwnerId")
				.InnerJoin("SysAdminUnit")
					.On("SysAdminUnit", "Id").IsEqual("SysAdminUnitInRole", "SysAdminUnitId")
				.Where(sysModuleVisaName, "StatusId").Not().In(Column.Parameters(finallyStatuses))
				.And(sysModuleVisaName, "IsCanceled").IsEqual(Column.Const(false))
				.And("SysAdminUnit", "ContactId").IsEqual(Column.Parameter(contactId));
			var count = visaSelect.ExecuteScalar<int>();
			return count;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Returns visa notification counters by contact.
		/// </summary>
		/// <param name="contactId">Contact identifier.</param>
		/// <returns>Dictionary, where key is group of count and value is count.</returns>
		public IDictionary<string, int> GetNotificationCount(Guid contactId) {
			contactId.CheckArgumentEmpty(nameof(contactId));
			var visaSchemaNames = GetVisaSchemasNames();
			var count = visaSchemaNames.Sum(visaSchemaName => GetVisaCount(visaSchemaName, contactId));
			return new Dictionary<string, int> {
				{NotificationGroupConst.Visa, count}
			};
		}

		#endregion
	}

	#endregion
}
