namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Common;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Entities.Events;

	#region Class: PartnershipPrmBaseEventListener

	/// <summary>
	/// Listener for Partnership entity events.
	/// </summary>
	/// <seealso cref="Terrasoft.Core.Entities.Events.BaseEntityEventListener" />
	[EntityEventListener(SchemaName = "Partnership")]
	public class PartnershipPrmBaseEventListener : BaseEntityEventListener
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
			var parthership = (Entity)sender;
			var rightsRegulator = new SspEntityRightsRegulator(parthership.UserConnection, parthership.SchemaName);
			rightsRegulator.GrantOrganizationReadRights(parthership.PrimaryColumnValue,
					parthership.GetTypedColumnValue<Guid>("AccountId"));
		}

		#endregion

	}

	#endregion

}

