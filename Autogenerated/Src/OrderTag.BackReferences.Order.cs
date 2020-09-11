namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OrderTag

	/// <exclude/>
	public class OrderTag : Terrasoft.Configuration.OrderTag
	{

		#region Constructors: Public

		public OrderTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public OrderTag(Terrasoft.Configuration.OrderTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<OrderInTag> OrderInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

