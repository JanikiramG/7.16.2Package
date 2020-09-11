namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: InvoiceVisa

	/// <exclude/>
	public class InvoiceVisa : Terrasoft.Configuration.InvoiceVisa
	{

		#region Constructors: Public

		public InvoiceVisa(UserConnection userConnection)
			: base(userConnection) {
		}

		public InvoiceVisa(Terrasoft.Configuration.InvoiceVisa source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

