namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SocialChannelFolder

	/// <exclude/>
	public class SocialChannelFolder : Terrasoft.Configuration.SocialChannelFolder
	{

		#region Constructors: Public

		public SocialChannelFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public SocialChannelFolder(Terrasoft.Configuration.SocialChannelFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SocialChannelFolder> SocialChannelFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<SocialChannelInFolder> SocialChannelInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

