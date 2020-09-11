namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwProjectProduct

	/// <exclude/>
	public class VwProjectProduct : Terrasoft.Configuration.VwProjectProduct
	{

		#region Constructors: Public

		public VwProjectProduct(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwProjectProduct(Terrasoft.Configuration.VwProjectProduct source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

