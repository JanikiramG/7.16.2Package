namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Entities.Events;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Store;

	#region Class: PRMTransactionEventListener

	/// <summary>
	/// Listener for 'PRMTransaction' entity events.
	/// </summary>
	/// <seealso cref="Terrasoft.Core.Entities.Events.BaseEntityEventListener" />
	[EntityEventListener(SchemaName = "PRMTransaction")]
	public class PRMTransactionEventListener : BaseEntityEventListener
	{

		#region Methods: Public

		/// <summary>
		/// Handles entity Saving event.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">The <see cref="T:Terrasoft.Core.Entities.EntityAfterEventArgs" /> instance containing the
		/// event data.</param>
		public override void OnSaving(object sender, EntityBeforeEventArgs e) {
			Entity prmTransactionEntity = (Entity)sender;
			Guid partnershipId = prmTransactionEntity.GetTypedColumnValue<Guid>("PartnershipId");
			if (partnershipId == Guid.Empty) {
				TransactionEnricher transactionEnricher = new TransactionEnricher(prmTransactionEntity.UserConnection);
				transactionEnricher.EnrichTransactionWithPartnership(prmTransactionEntity);
			}
			base.OnSaving(sender, e);
		}

		#endregion

	}

	#endregion

}

