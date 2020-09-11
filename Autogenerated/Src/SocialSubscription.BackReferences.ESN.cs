namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SocialSubscription

	/// <exclude/>
	public class SocialSubscription : Terrasoft.Configuration.SocialSubscription
	{

		#region Constructors: Public

		public SocialSubscription(UserConnection userConnection)
			: base(userConnection) {
		}

		public SocialSubscription(Terrasoft.Configuration.SocialSubscription source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

