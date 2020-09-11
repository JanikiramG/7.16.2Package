namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PaymentType

	/// <exclude/>
	public class PaymentType : Terrasoft.Configuration.PaymentType
	{

		#region Constructors: Public

		public PaymentType(UserConnection userConnection)
			: base(userConnection) {
		}

		public PaymentType(Terrasoft.Configuration.PaymentType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Order> OrderCollectionByPaymentType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

