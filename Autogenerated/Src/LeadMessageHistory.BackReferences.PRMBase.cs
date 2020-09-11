namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LeadMessageHistory

	/// <exclude/>
	public class LeadMessageHistory : Terrasoft.Configuration.LeadMessageHistory
	{

		#region Constructors: Public

		public LeadMessageHistory(UserConnection userConnection)
			: base(userConnection) {
		}

		public LeadMessageHistory(Terrasoft.Configuration.LeadMessageHistory source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

