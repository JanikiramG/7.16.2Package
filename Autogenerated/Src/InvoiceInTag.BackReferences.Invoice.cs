namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: InvoiceInTag

	/// <exclude/>
	public class InvoiceInTag : Terrasoft.Configuration.InvoiceInTag
	{

		#region Constructors: Public

		public InvoiceInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public InvoiceInTag(Terrasoft.Configuration.InvoiceInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

