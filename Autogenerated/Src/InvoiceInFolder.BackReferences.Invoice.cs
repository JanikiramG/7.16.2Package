namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: InvoiceInFolder

	/// <exclude/>
	public class InvoiceInFolder : Terrasoft.Configuration.InvoiceInFolder
	{

		#region Constructors: Public

		public InvoiceInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public InvoiceInFolder(Terrasoft.Configuration.InvoiceInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

