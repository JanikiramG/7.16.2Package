namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OppContactInfluence

	/// <exclude/>
	public class OppContactInfluence : Terrasoft.Configuration.OppContactInfluence
	{

		#region Constructors: Public

		public OppContactInfluence(UserConnection userConnection)
			: base(userConnection) {
		}

		public OppContactInfluence(Terrasoft.Configuration.OppContactInfluence source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<OpportunityContact> OpportunityContactCollectionByInfluence {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

