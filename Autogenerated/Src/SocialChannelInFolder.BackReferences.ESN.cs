namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SocialChannelInFolder

	/// <exclude/>
	public class SocialChannelInFolder : Terrasoft.Configuration.SocialChannelInFolder
	{

		#region Constructors: Public

		public SocialChannelInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public SocialChannelInFolder(Terrasoft.Configuration.SocialChannelInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

