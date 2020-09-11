namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Warehouse

	/// <exclude/>
	public class Warehouse : Terrasoft.Configuration.Warehouse
	{

		#region Constructors: Public

		public Warehouse(UserConnection userConnection)
			: base(userConnection) {
		}

		public Warehouse(Terrasoft.Configuration.Warehouse source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ProductStockBalance> ProductStockBalanceCollectionByWarehouse {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

