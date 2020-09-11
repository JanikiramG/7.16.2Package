namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DeliveryType

	/// <exclude/>
	public class DeliveryType : Terrasoft.Configuration.DeliveryType
	{

		#region Constructors: Public

		public DeliveryType(UserConnection userConnection)
			: base(userConnection) {
		}

		public DeliveryType(Terrasoft.Configuration.DeliveryType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Order> OrderCollectionByDeliveryType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

