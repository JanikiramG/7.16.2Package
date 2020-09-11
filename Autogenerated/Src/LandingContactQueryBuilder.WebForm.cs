namespace Terrasoft.Configuration
{
	using System;
	using Core;
	using Core.DB;
	using Core.Entities;

	#region Class: LandingContactQueryBuilder

	/// <summary>
	/// Base class for the specific query builders.
	/// </summary>
	/// <typeparam name="T">Type of Entity that is generating by landing.</typeparam>
	public abstract class LandingContactQueryBuilder<T> : ILandingContactQueryBuilder where T : Entity
	{

		#region Properties: Public

		/// <summary>
		/// The name of LandingId column.
		/// </summary>
		public string WebFormIdColumnName {
			get;
			set;
		}

		/// <summary>
		/// The name of ContactId column.
		/// </summary>
		public string ContactIdColumnName {
			get;
			set;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Returns select of Contact unique identifiers related to the <paramref name="webFormId"/>. 
		/// </summary>
		/// <param name="userConnection">An instance of the <see cref="UserConnection"/> type.</param>
		/// <param name="webFormId">The unique identifier of landing.</param>
		/// <returns>Select query that returns a list of contact unique identifiers.</returns>
		public virtual Select GetRelatedContactsSelect(UserConnection userConnection, Guid webFormId) {
			var entity = userConnection.EntitySchemaManager.GetInstanceByName(typeof(T).Name);
			var select = new Select(userConnection)
				.Distinct()
				.Column(entity.Name, ContactIdColumnName)
				.From(entity.Name)
				.InnerJoin("GeneratedWebForm").As("GWF").On("GWF", "Id").IsEqual(entity.Name, WebFormIdColumnName)
				.Where(entity.Name, WebFormIdColumnName).IsEqual(Column.Parameter(webFormId))
					.And("GWF", "StateId").IsEqual(Column.Parameter(LendingConsts.ActiveLendingStateId))
					.And(entity.Name, ContactIdColumnName).Not().IsNull() as Select;
			select.SpecifyNoLockHints();
			return select;
		} 

		#endregion

	}

	#endregion

}
