namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LeadSourceUrl

	/// <exclude/>
	public class LeadSourceUrl : Terrasoft.Configuration.LeadSourceUrl
	{

		#region Constructors: Public

		public LeadSourceUrl(UserConnection userConnection)
			: base(userConnection) {
		}

		public LeadSourceUrl(Terrasoft.Configuration.LeadSourceUrl source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

