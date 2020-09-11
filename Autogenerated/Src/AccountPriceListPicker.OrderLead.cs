namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Factories;

	#region Class: AccountPriceListPicker

	/// <summary>
	/// Class for selection PriceList from Account.
	/// </summary>
	[DefaultBinding(typeof(IPriceListPicker))]
	public class AccountPriceListPicker : IPriceListPicker
	{
		#region Fields: Protected

		protected readonly UserConnection UserConnection;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="AccountPriceListPicker"/> class.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		public AccountPriceListPicker(UserConnection userConnection) {
			UserConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		private Select GetAccountPriceListSelect(Guid accountId) {
			return new Select(UserConnection)
					.Column("PriceListId")
					.From("Account")
					.Where("Id").IsEqual(Column.Const(accountId))
				as Select;
		}

		#endregion

		#region Methods: Protected

		protected Guid GetPriceListByAccount(Guid accountId) {
			var accountSelect = GetAccountPriceListSelect(accountId);
			accountSelect.ExecuteSingleRecord<Guid>(reader =>
				reader.GetColumnValue<Guid>("PriceListId"), out Guid result);
			return result;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Get pricelist using account.
		/// </summary>
		/// /// <param name="accountId">Account identifier.</param>
		/// <returns>PriceList</returns>
		public virtual Guid GetPriceList(Guid accountId) {
			return GetPriceListByAccount(accountId);
		}

		#endregion
	}

	#endregion

}
