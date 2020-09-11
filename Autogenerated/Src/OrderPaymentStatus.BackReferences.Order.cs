namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OrderPaymentStatus

	/// <exclude/>
	public class OrderPaymentStatus : Terrasoft.Configuration.OrderPaymentStatus
	{

		#region Constructors: Public

		public OrderPaymentStatus(UserConnection userConnection)
			: base(userConnection) {
		}

		public OrderPaymentStatus(Terrasoft.Configuration.OrderPaymentStatus source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Order> OrderCollectionByPaymentStatus {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

