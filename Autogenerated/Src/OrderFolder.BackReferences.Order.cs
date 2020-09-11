namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OrderFolder

	/// <exclude/>
	public class OrderFolder : Terrasoft.Configuration.OrderFolder
	{

		#region Constructors: Public

		public OrderFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public OrderFolder(Terrasoft.Configuration.OrderFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<OrderFolder> OrderFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<OrderInFolder> OrderInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

