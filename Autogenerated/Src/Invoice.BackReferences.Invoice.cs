namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Invoice

	/// <exclude/>
	public class Invoice : Terrasoft.Configuration.Invoice
	{

		#region Constructors: Public

		public Invoice(UserConnection userConnection)
			: base(userConnection) {
		}

		public Invoice(Terrasoft.Configuration.Invoice source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByInvoice {
			get;
			set;
		}

		public IEnumerable<EmailFolderColumnValuesSetting> EmailFolderColumnValuesSettingCollectionByInvoice {
			get;
			set;
		}

		public IEnumerable<InvoiceFile> InvoiceFileCollectionByInvoice {
			get;
			set;
		}

		public IEnumerable<InvoiceInFolder> InvoiceInFolderCollectionByInvoice {
			get;
			set;
		}

		public IEnumerable<InvoiceInTag> InvoiceInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<InvoiceProduct> InvoiceProductCollectionByInvoice {
			get;
			set;
		}

		public IEnumerable<InvoiceVisa> InvoiceVisaCollectionByInvoice {
			get;
			set;
		}

		public IEnumerable<SupplyPaymentElement> SupplyPaymentElementCollectionByInvoice {
			get;
			set;
		}

		public IEnumerable<VwInvoiceProduct> VwInvoiceProductCollectionByInvoice {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

