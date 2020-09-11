namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OppContactLoyality

	/// <exclude/>
	public class OppContactLoyality : Terrasoft.Configuration.OppContactLoyality
	{

		#region Constructors: Public

		public OppContactLoyality(UserConnection userConnection)
			: base(userConnection) {
		}

		public OppContactLoyality(Terrasoft.Configuration.OppContactLoyality source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<OpportunityContact> OpportunityContactCollectionByContactLoyality {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

