namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: InvoicePaymentStatus

	/// <exclude/>
	public class InvoicePaymentStatus : Terrasoft.Configuration.InvoicePaymentStatus
	{

		#region Constructors: Public

		public InvoicePaymentStatus(UserConnection userConnection)
			: base(userConnection) {
		}

		public InvoicePaymentStatus(Terrasoft.Configuration.InvoicePaymentStatus source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Invoice> InvoiceCollectionByPaymentStatus {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

