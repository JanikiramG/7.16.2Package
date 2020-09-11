namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: WSysAccountTag

	/// <exclude/>
	public class WSysAccountTag : Terrasoft.Configuration.WSysAccountTag
	{

		#region Constructors: Public

		public WSysAccountTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public WSysAccountTag(Terrasoft.Configuration.WSysAccountTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<WSysAccountInTag> WSysAccountInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

