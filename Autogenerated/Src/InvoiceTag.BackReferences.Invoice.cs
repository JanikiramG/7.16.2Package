namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: InvoiceTag

	/// <exclude/>
	public class InvoiceTag : Terrasoft.Configuration.InvoiceTag
	{

		#region Constructors: Public

		public InvoiceTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public InvoiceTag(Terrasoft.Configuration.InvoiceTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<InvoiceInTag> InvoiceInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

