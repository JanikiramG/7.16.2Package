namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SocialUnsubscription

	/// <exclude/>
	public class SocialUnsubscription : Terrasoft.Configuration.SocialUnsubscription
	{

		#region Constructors: Public

		public SocialUnsubscription(UserConnection userConnection)
			: base(userConnection) {
		}

		public SocialUnsubscription(Terrasoft.Configuration.SocialUnsubscription source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

