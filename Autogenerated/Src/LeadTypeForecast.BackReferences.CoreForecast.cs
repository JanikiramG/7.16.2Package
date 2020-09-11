namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LeadTypeForecast

	/// <exclude/>
	public class LeadTypeForecast : Terrasoft.Configuration.LeadTypeForecast
	{

		#region Constructors: Public

		public LeadTypeForecast(UserConnection userConnection)
			: base(userConnection) {
		}

		public LeadTypeForecast(Terrasoft.Configuration.LeadTypeForecast source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

