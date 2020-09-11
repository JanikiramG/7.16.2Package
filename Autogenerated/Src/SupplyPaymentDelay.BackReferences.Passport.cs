namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SupplyPaymentDelay

	/// <exclude/>
	public class SupplyPaymentDelay : Terrasoft.Configuration.SupplyPaymentDelay
	{

		#region Constructors: Public

		public SupplyPaymentDelay(UserConnection userConnection)
			: base(userConnection) {
		}

		public SupplyPaymentDelay(Terrasoft.Configuration.SupplyPaymentDelay source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SupplyPaymentElement> SupplyPaymentElementCollectionByDelayType {
			get;
			set;
		}

		public IEnumerable<SupplyPaymentTemplateItem> SupplyPaymentTemplateItemCollectionByDelayType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

