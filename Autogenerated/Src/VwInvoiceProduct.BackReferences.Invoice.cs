namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwInvoiceProduct

	/// <exclude/>
	public class VwInvoiceProduct : Terrasoft.Configuration.VwInvoiceProduct
	{

		#region Constructors: Public

		public VwInvoiceProduct(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwInvoiceProduct(Terrasoft.Configuration.VwInvoiceProduct source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

