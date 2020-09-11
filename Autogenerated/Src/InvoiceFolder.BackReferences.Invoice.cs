namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: InvoiceFolder

	/// <exclude/>
	public class InvoiceFolder : Terrasoft.Configuration.InvoiceFolder
	{

		#region Constructors: Public

		public InvoiceFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public InvoiceFolder(Terrasoft.Configuration.InvoiceFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<InvoiceFolder> InvoiceFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<InvoiceInFolder> InvoiceInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

