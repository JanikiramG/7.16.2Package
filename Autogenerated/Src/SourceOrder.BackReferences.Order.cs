namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SourceOrder

	/// <exclude/>
	public class SourceOrder : Terrasoft.Configuration.SourceOrder
	{

		#region Constructors: Public

		public SourceOrder(UserConnection userConnection)
			: base(userConnection) {
		}

		public SourceOrder(Terrasoft.Configuration.SourceOrder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Order> OrderCollectionBySourceOrder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

