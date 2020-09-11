namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PartnershipFile

	/// <exclude/>
	public class PartnershipFile : Terrasoft.Configuration.PartnershipFile
	{

		#region Constructors: Public

		public PartnershipFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public PartnershipFile(Terrasoft.Configuration.PartnershipFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

