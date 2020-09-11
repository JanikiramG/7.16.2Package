namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: InvoiceProduct

	/// <exclude/>
	public class InvoiceProduct : Terrasoft.Configuration.InvoiceProduct
	{

		#region Constructors: Public

		public InvoiceProduct(UserConnection userConnection)
			: base(userConnection) {
		}

		public InvoiceProduct(Terrasoft.Configuration.InvoiceProduct source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

