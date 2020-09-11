namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SupplyPaymentState

	/// <exclude/>
	public class SupplyPaymentState : Terrasoft.Configuration.SupplyPaymentState
	{

		#region Constructors: Public

		public SupplyPaymentState(UserConnection userConnection)
			: base(userConnection) {
		}

		public SupplyPaymentState(Terrasoft.Configuration.SupplyPaymentState source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SupplyPaymentElement> SupplyPaymentElementCollectionByState {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

