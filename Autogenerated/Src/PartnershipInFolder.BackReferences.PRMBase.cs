namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PartnershipInFolder

	/// <exclude/>
	public class PartnershipInFolder : Terrasoft.Configuration.PartnershipInFolder
	{

		#region Constructors: Public

		public PartnershipInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public PartnershipInFolder(Terrasoft.Configuration.PartnershipInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

