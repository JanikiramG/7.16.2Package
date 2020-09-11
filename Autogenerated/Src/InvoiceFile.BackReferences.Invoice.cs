namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: InvoiceFile

	/// <exclude/>
	public class InvoiceFile : Terrasoft.Configuration.InvoiceFile
	{

		#region Constructors: Public

		public InvoiceFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public InvoiceFile(Terrasoft.Configuration.InvoiceFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

