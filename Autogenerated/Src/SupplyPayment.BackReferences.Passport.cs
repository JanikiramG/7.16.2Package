namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SupplyPayment

	/// <exclude/>
	public class SupplyPayment : Terrasoft.Configuration.SupplyPayment
	{

		#region Constructors: Public

		public SupplyPayment(UserConnection userConnection)
			: base(userConnection) {
		}

		public SupplyPayment(Terrasoft.Configuration.SupplyPayment source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

