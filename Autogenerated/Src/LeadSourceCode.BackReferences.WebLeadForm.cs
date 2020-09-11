namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LeadSourceCode

	/// <exclude/>
	public class LeadSourceCode : Terrasoft.Configuration.LeadSourceCode
	{

		#region Constructors: Public

		public LeadSourceCode(UserConnection userConnection)
			: base(userConnection) {
		}

		public LeadSourceCode(Terrasoft.Configuration.LeadSourceCode source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

