namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Entities.Events;

	#region Class: LeadOwnerEventListener

	/// <summary>
	/// Listener of owner on Opportunity entity.
	/// </summary>
	/// <seealso cref="Terrasoft.Core.Entities.Events.BaseEntityEventListener" />
	[EntityEventListener(SchemaName = "Opportunity")]
	public class OpportunityOwnerEventListener : BaseEntityOwnerEventListener
	{
		
	}

	#endregion

}

