namespace Terrasoft.Configuration
{
	using System;
	using Core;
	using Core.DB;

	#region Interface: ILandingContactQueryBuilder

	/// <summary>
	/// Interface for all concrete query builders.
	/// </summary>
	public interface ILandingContactQueryBuilder
	{

		#region Properties: Public

		/// <summary>
		/// The name of ContactId column.
		/// </summary>
		string ContactIdColumnName {
			get; set;
		}

		/// <summary>
		/// The name of LandingId column.
		/// </summary>
		string WebFormIdColumnName {
			get; set;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Returns select of Contact unique identifiers related to the <paramref name="webFormId"/>. 
		/// </summary>
		/// <param name="userConnection">An instance of the <see cref="UserConnection"/> type.</param>
		/// <param name="webFormId">The unique identifier of landing.</param>
		/// <returns>Select query that returns a list of contact unique identifiers.</returns>
		Select GetRelatedContactsSelect(UserConnection userConnection, Guid webFormId);

		#endregion

	}

	#endregion

}
