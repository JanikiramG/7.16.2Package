namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SocialChannelInTag

	/// <exclude/>
	public class SocialChannelInTag : Terrasoft.Configuration.SocialChannelInTag
	{

		#region Constructors: Public

		public SocialChannelInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public SocialChannelInTag(Terrasoft.Configuration.SocialChannelInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

