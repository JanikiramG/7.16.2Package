namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SocialMentionSearchRule

	/// <exclude/>
	public class SocialMentionSearchRule : Terrasoft.Configuration.SocialMentionSearchRule
	{

		#region Constructors: Public

		public SocialMentionSearchRule(UserConnection userConnection)
			: base(userConnection) {
		}

		public SocialMentionSearchRule(Terrasoft.Configuration.SocialMentionSearchRule source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

