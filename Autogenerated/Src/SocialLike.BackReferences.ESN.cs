namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SocialLike

	/// <exclude/>
	public class SocialLike : Terrasoft.Configuration.SocialLike
	{

		#region Constructors: Public

		public SocialLike(UserConnection userConnection)
			: base(userConnection) {
		}

		public SocialLike(Terrasoft.Configuration.SocialLike source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

