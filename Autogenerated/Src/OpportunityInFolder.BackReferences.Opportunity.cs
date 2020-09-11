namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityInFolder

	/// <exclude/>
	public class OpportunityInFolder : Terrasoft.Configuration.OpportunityInFolder
	{

		#region Constructors: Public

		public OpportunityInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityInFolder(Terrasoft.Configuration.OpportunityInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

