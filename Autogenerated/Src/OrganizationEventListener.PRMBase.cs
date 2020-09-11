namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Common;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Entities.Events;

	#region Class: OrganizationEventListener

	/// <summary>
	/// Listener for Organization entity events.
	/// </summary>
	/// <seealso cref="Terrasoft.Core.Entities.Events.BaseEntityEventListener" />
	[EntityEventListener(SchemaName = "VwSspAdminUnit")]
	public class OrganizationEventListener : BaseEntityEventListener
	{

		#region Methods: Public

		/// <summary>
		/// Handles entity Inserted event.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">The <see cref="T:Terrasoft.Core.Entities.EntityAfterEventArgs" /> instance containing the
		/// event data.</param>
		public override void OnInserted(object sender, EntityAfterEventArgs e) {
			base.OnInserted(sender, e);
			var organization = (Entity)sender;
			var accountId = organization.GetTypedColumnValue<Guid>("PortalAccountId");
			if(accountId.IsNotEmpty()) {
				var rightsRegulator = new PartnershipRightsDistributor(organization.UserConnection);
				rightsRegulator.GrantPartnershipReadRightsToOrganization(organization.PrimaryColumnValue, accountId);
			}

		}

		#endregion

	}

	#endregion

}

