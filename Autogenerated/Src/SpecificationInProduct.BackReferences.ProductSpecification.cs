namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SpecificationInProduct

	/// <exclude/>
	public class SpecificationInProduct : Terrasoft.Configuration.SpecificationInProduct
	{

		#region Constructors: Public

		public SpecificationInProduct(UserConnection userConnection)
			: base(userConnection) {
		}

		public SpecificationInProduct(Terrasoft.Configuration.SpecificationInProduct source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

