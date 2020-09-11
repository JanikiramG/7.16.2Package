namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: TradeMark

	/// <exclude/>
	public class TradeMark : Terrasoft.Configuration.TradeMark
	{

		#region Constructors: Public

		public TradeMark(UserConnection userConnection)
			: base(userConnection) {
		}

		public TradeMark(Terrasoft.Configuration.TradeMark source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Product> ProductCollectionByTradeMark {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

