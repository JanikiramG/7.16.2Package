namespace Terrasoft.Configuration
{

	#region Class: EventTargetQueryBuilder

	/// <summary>
	/// Concrete query builder for all web forms with Lead type.
	/// </summary>
	public sealed class LeadQueryBuilder : LandingContactQueryBuilder<Lead>
	{

		#region Constructors: Public

		public LeadQueryBuilder() : base() {
			WebFormIdColumnName = "WebFormId";
			ContactIdColumnName = "QualifiedContactId";
		}

		#endregion

	}

	#endregion

}
