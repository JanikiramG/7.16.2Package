namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OppContactRole

	/// <exclude/>
	public class OppContactRole : Terrasoft.Configuration.OppContactRole
	{

		#region Constructors: Public

		public OppContactRole(UserConnection userConnection)
			: base(userConnection) {
		}

		public OppContactRole(Terrasoft.Configuration.OppContactRole source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<OpportunityContact> OpportunityContactCollectionByRole {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

