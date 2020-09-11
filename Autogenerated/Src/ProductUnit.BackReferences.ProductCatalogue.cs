namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProductUnit

	/// <exclude/>
	public class ProductUnit : Terrasoft.Configuration.ProductUnit
	{

		#region Constructors: Public

		public ProductUnit(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProductUnit(Terrasoft.Configuration.ProductUnit source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

