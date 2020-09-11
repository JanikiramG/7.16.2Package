namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LeadInTag

	/// <exclude/>
	public class LeadInTag : Terrasoft.Configuration.LeadInTag
	{

		#region Constructors: Public

		public LeadInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public LeadInTag(Terrasoft.Configuration.LeadInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

