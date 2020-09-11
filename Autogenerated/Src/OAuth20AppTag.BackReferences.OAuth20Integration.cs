namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OAuth20AppTag

	/// <exclude/>
	public class OAuth20AppTag : Terrasoft.Configuration.OAuth20AppTag
	{

		#region Constructors: Public

		public OAuth20AppTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public OAuth20AppTag(Terrasoft.Configuration.OAuth20AppTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<OAuth20AppInTag> OAuth20AppInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

