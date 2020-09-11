namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SupplyPaymentTemplate

	/// <exclude/>
	public class SupplyPaymentTemplate : Terrasoft.Configuration.SupplyPaymentTemplate
	{

		#region Constructors: Public

		public SupplyPaymentTemplate(UserConnection userConnection)
			: base(userConnection) {
		}

		public SupplyPaymentTemplate(Terrasoft.Configuration.SupplyPaymentTemplate source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SupplyPaymentTemplateItem> SupplyPaymentTemplateItemCollectionBySupplyPaymentTemplate {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

