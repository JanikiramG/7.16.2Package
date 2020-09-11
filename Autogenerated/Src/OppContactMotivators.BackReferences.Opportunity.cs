namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OppContactMotivators

	/// <exclude/>
	public class OppContactMotivators : Terrasoft.Configuration.OppContactMotivators
	{

		#region Constructors: Public

		public OppContactMotivators(UserConnection userConnection)
			: base(userConnection) {
		}

		public OppContactMotivators(Terrasoft.Configuration.OppContactMotivators source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<OppContactMotivator> OppContactMotivatorCollectionByContactMotivator {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

