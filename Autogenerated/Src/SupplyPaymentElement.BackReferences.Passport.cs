namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SupplyPaymentElement

	/// <exclude/>
	public class SupplyPaymentElement : Terrasoft.Configuration.SupplyPaymentElement
	{

		#region Constructors: Public

		public SupplyPaymentElement(UserConnection userConnection)
			: base(userConnection) {
		}

		public SupplyPaymentElement(Terrasoft.Configuration.SupplyPaymentElement source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SupplyPaymentElement> SupplyPaymentElementCollectionByPreviousElement {
			get;
			set;
		}

		public IEnumerable<SupplyPaymentProduct> SupplyPaymentProductCollectionBySupplyPaymentElement {
			get;
			set;
		}

		public IEnumerable<VwSupplyPaymentProduct> VwSupplyPaymentProductCollectionBySupplyPaymentElement {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

