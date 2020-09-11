namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OrderDeliveryStatus

	/// <exclude/>
	public class OrderDeliveryStatus : Terrasoft.Configuration.OrderDeliveryStatus
	{

		#region Constructors: Public

		public OrderDeliveryStatus(UserConnection userConnection)
			: base(userConnection) {
		}

		public OrderDeliveryStatus(Terrasoft.Configuration.OrderDeliveryStatus source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Order> OrderCollectionByDeliveryStatus {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

