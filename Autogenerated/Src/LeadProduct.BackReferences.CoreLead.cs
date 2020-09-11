namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LeadProduct

	/// <exclude/>
	public class LeadProduct : Terrasoft.Configuration.LeadProduct
	{

		#region Constructors: Public

		public LeadProduct(UserConnection userConnection)
			: base(userConnection) {
		}

		public LeadProduct(Terrasoft.Configuration.LeadProduct source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

