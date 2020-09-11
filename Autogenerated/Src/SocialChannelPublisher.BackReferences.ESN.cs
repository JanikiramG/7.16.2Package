namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SocialChannelPublisher

	/// <exclude/>
	public class SocialChannelPublisher : Terrasoft.Configuration.SocialChannelPublisher
	{

		#region Constructors: Public

		public SocialChannelPublisher(UserConnection userConnection)
			: base(userConnection) {
		}

		public SocialChannelPublisher(Terrasoft.Configuration.SocialChannelPublisher source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

