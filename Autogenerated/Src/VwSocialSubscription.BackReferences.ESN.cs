namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSocialSubscription

	/// <exclude/>
	public class VwSocialSubscription : Terrasoft.Configuration.VwSocialSubscription
	{

		#region Constructors: Public

		public VwSocialSubscription(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSocialSubscription(Terrasoft.Configuration.VwSocialSubscription source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

