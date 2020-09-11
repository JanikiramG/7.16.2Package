namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SocialChannel

	/// <exclude/>
	public class SocialChannel : Terrasoft.Configuration.SocialChannel
	{

		#region Constructors: Public

		public SocialChannel(UserConnection userConnection)
			: base(userConnection) {
		}

		public SocialChannel(Terrasoft.Configuration.SocialChannel source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SocialChannelInFolder> SocialChannelInFolderCollectionBySocialChannel {
			get;
			set;
		}

		public IEnumerable<SocialChannelInTag> SocialChannelInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<SocialChannelPublisher> SocialChannelPublisherCollectionByChannel {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

