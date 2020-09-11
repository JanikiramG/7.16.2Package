namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityVisa

	/// <exclude/>
	public class OpportunityVisa : Terrasoft.Configuration.OpportunityVisa
	{

		#region Constructors: Public

		public OpportunityVisa(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityVisa(Terrasoft.Configuration.OpportunityVisa source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

