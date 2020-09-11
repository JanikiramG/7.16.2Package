namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OrderFile

	/// <exclude/>
	public class OrderFile : Terrasoft.Configuration.OrderFile
	{

		#region Constructors: Public

		public OrderFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public OrderFile(Terrasoft.Configuration.OrderFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

