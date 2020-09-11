namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Entities.Events;

	#region Class: LeadOwnerEventListener

	/// <summary>
	/// Listener of owner on Lead entity.
	/// </summary>
	/// <seealso cref="Terrasoft.Core.Entities.Events.BaseEntityEventListener" />
	[EntityEventListener(SchemaName = "Lead")]
	public class LeadOwnerEventListener : BaseEntityOwnerEventListener
	{

	}

	#endregion

}

