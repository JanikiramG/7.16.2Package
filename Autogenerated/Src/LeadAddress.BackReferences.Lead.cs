namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LeadAddress

	/// <exclude/>
	public class LeadAddress : Terrasoft.Configuration.LeadAddress
	{

		#region Constructors: Public

		public LeadAddress(UserConnection userConnection)
			: base(userConnection) {
		}

		public LeadAddress(Terrasoft.Configuration.LeadAddress source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

