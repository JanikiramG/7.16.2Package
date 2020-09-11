namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OrderInFolder

	/// <exclude/>
	public class OrderInFolder : Terrasoft.Configuration.OrderInFolder
	{

		#region Constructors: Public

		public OrderInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public OrderInFolder(Terrasoft.Configuration.OrderInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

