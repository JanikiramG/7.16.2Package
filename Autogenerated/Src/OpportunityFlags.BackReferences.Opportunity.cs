namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityFlags

	/// <exclude/>
	public class OpportunityFlags : Terrasoft.Configuration.OpportunityFlags
	{

		#region Constructors: Public

		public OpportunityFlags(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityFlags(Terrasoft.Configuration.OpportunityFlags source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

