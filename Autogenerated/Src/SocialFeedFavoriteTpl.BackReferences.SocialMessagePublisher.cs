namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SocialFeedFavoriteTpl

	/// <exclude/>
	public class SocialFeedFavoriteTpl : Terrasoft.Configuration.SocialFeedFavoriteTpl
	{

		#region Constructors: Public

		public SocialFeedFavoriteTpl(UserConnection userConnection)
			: base(userConnection) {
		}

		public SocialFeedFavoriteTpl(Terrasoft.Configuration.SocialFeedFavoriteTpl source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

