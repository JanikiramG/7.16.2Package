namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Configuration.RightsService;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Entities.Events;

	#region Class: SysAdminUnitEventListener

	/// <summary>
	/// Listener for 'SysAdminUnit' entity events.
	/// </summary>
	/// <seealso cref="Terrasoft.Core.Entities.Events.BaseEntityEventListener" />
	[EntityEventListener(SchemaName = "SysAdminUnit")]
	public class SysAdminUnitEventListener : BaseEntityEventListener
	{
		#region Properties: Public

		public RightsHelper RightsHelper;

		#endregion

		#region Methods: Public

		/// <summary>
		/// Handles entity Inserted event.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">The <see cref="T:Terrasoft.Core.Entities.EntityAfterEventArgs" /> instance containing the
		/// event data.</param>
		public override void OnInserted(object sender, EntityAfterEventArgs e) {
			base.OnInserted(sender, e);
			Entity adminUnit = (Entity)sender;
			if (adminUnit.GetTypedColumnValue<Guid>("ContactId") != Guid.Empty &&
				adminUnit.GetTypedColumnValue<bool>("ConnectionType")) {
				RightsHelper = RightsHelper ?? new RightsHelper(adminUnit.UserConnection);
				RightsHelper.SetRecordRight(adminUnit.GetTypedColumnValue<Guid>("Id"), "Contact",
					adminUnit.GetTypedColumnValue<string>("ContactId"), 0, 2);
				RightsHelper.SetRecordRight(adminUnit.GetTypedColumnValue<Guid>("Id"), "Contact",
					adminUnit.GetTypedColumnValue<string>("ContactId"), 1, 2);
			}
		}

		#endregion

	}

	#endregion

}

