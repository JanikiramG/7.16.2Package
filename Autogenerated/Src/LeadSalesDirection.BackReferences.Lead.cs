namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LeadSalesDirection

	/// <exclude/>
	public class LeadSalesDirection : Terrasoft.Configuration.LeadSalesDirection
	{

		#region Constructors: Public

		public LeadSalesDirection(UserConnection userConnection)
			: base(userConnection) {
		}

		public LeadSalesDirection(Terrasoft.Configuration.LeadSalesDirection source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

