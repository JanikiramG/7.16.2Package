namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OrderStatus

	/// <exclude/>
	public class OrderStatus : Terrasoft.Configuration.OrderStatus
	{

		#region Constructors: Public

		public OrderStatus(UserConnection userConnection)
			: base(userConnection) {
		}

		public OrderStatus(Terrasoft.Configuration.OrderStatus source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Order> OrderCollectionByStatus {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

