namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OrderInTag

	/// <exclude/>
	public class OrderInTag : Terrasoft.Configuration.OrderInTag
	{

		#region Constructors: Public

		public OrderInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public OrderInTag(Terrasoft.Configuration.OrderInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

