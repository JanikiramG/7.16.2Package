namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PartnershipParameter

	/// <exclude/>
	public class PartnershipParameter : Terrasoft.Configuration.PartnershipParameter
	{

		#region Constructors: Public

		public PartnershipParameter(UserConnection userConnection)
			: base(userConnection) {
		}

		public PartnershipParameter(Terrasoft.Configuration.PartnershipParameter source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

