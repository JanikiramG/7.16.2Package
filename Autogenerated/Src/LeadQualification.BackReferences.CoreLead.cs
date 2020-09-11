namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LeadQualification

	/// <exclude/>
	public class LeadQualification : Terrasoft.Configuration.LeadQualification
	{

		#region Constructors: Public

		public LeadQualification(UserConnection userConnection)
			: base(userConnection) {
		}

		public LeadQualification(Terrasoft.Configuration.LeadQualification source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

