namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwProductInLeadType

	/// <exclude/>
	public class VwProductInLeadType : Terrasoft.Configuration.VwProductInLeadType
	{

		#region Constructors: Public

		public VwProductInLeadType(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwProductInLeadType(Terrasoft.Configuration.VwProductInLeadType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

