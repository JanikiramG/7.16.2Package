namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProductForecast

	/// <exclude/>
	public class ProductForecast : Terrasoft.Configuration.ProductForecast
	{

		#region Constructors: Public

		public ProductForecast(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProductForecast(Terrasoft.Configuration.ProductForecast source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

