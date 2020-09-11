namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: WSysAccount

	/// <exclude/>
	public class WSysAccount : Terrasoft.Configuration.WSysAccount
	{

		#region Constructors: Public

		public WSysAccount(UserConnection userConnection)
			: base(userConnection) {
		}

		public WSysAccount(Terrasoft.Configuration.WSysAccount source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<WSysAccountInTag> WSysAccountInTagCollectionByEntity {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

