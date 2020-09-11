namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LeadInFolder

	/// <exclude/>
	public class LeadInFolder : Terrasoft.Configuration.LeadInFolder
	{

		#region Constructors: Public

		public LeadInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public LeadInFolder(Terrasoft.Configuration.LeadInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

