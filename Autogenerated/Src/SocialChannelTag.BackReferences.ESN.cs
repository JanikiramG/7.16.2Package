namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SocialChannelTag

	/// <exclude/>
	public class SocialChannelTag : Terrasoft.Configuration.SocialChannelTag
	{

		#region Constructors: Public

		public SocialChannelTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public SocialChannelTag(Terrasoft.Configuration.SocialChannelTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SocialChannelInTag> SocialChannelInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

