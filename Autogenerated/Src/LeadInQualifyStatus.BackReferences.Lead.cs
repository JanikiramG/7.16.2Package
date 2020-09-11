namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LeadInQualifyStatus

	/// <exclude/>
	public class LeadInQualifyStatus : Terrasoft.Configuration.LeadInQualifyStatus
	{

		#region Constructors: Public

		public LeadInQualifyStatus(UserConnection userConnection)
			: base(userConnection) {
		}

		public LeadInQualifyStatus(Terrasoft.Configuration.LeadInQualifyStatus source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

