namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OrderVisa

	/// <exclude/>
	public class OrderVisa : Terrasoft.Configuration.OrderVisa
	{

		#region Constructors: Public

		public OrderVisa(UserConnection userConnection)
			: base(userConnection) {
		}

		public OrderVisa(Terrasoft.Configuration.OrderVisa source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

