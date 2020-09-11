namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LeadMediumCode

	/// <exclude/>
	public class LeadMediumCode : Terrasoft.Configuration.LeadMediumCode
	{

		#region Constructors: Public

		public LeadMediumCode(UserConnection userConnection)
			: base(userConnection) {
		}

		public LeadMediumCode(Terrasoft.Configuration.LeadMediumCode source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

