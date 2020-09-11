namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SupplyPaymentTemplateItem

	/// <exclude/>
	public class SupplyPaymentTemplateItem : Terrasoft.Configuration.SupplyPaymentTemplateItem
	{

		#region Constructors: Public

		public SupplyPaymentTemplateItem(UserConnection userConnection)
			: base(userConnection) {
		}

		public SupplyPaymentTemplateItem(Terrasoft.Configuration.SupplyPaymentTemplateItem source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SupplyPaymentTemplateItem> SupplyPaymentTemplateItemCollectionByPreviousElement {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

